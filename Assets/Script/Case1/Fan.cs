using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : ShootableObject
{
    public float stateDuration = 5f;
    public CasaLuciaController controller;
    [SerializeField]
    private State currentState;

    private Animator anim;
    private float currentStateTime;

    // Start is called before the first frame update
    void Start()
    {
        controller = (CasaLuciaController) FindObjectOfType(typeof(CasaLuciaController));

        anim = gameObject.GetComponent<Animator>();
        currentStateTime = stateDuration;
        ResetScene();
    }

    // Update is called once per frame
    void Update()
    {
        currentStateTime -= Time.deltaTime;
        if (currentStateTime < 0)
        {
            currentState = Next(currentState);
            UpdateScene();
        }        
    }

    public override void OnShoot()
    {
        currentState = State.FAST;
        UpdateScene();
    }

    public void ResetScene()
    {
        OnShoot();
    }

    private void UpdateScene()
    {
        controller.CurrentFanState = currentState;
        currentStateTime = stateDuration;
        anim.speed = StateSpeed(currentState);

        CheckNotIdle();
    }

    private void CheckNotIdle()
    {
        if (currentState == State.IDLE)
        {
            var player = GameObject.FindGameObjectsWithTag("Player");
            Destroy(player[0]);
            controller.KillPlayer();
        }
    }

    private float StateSpeed(State current)
    {
        switch (current)
        {
            case State.IDLE :
                return 0f;
            case State.SLOW :
                return .8f;
            case State.MID :
                return 1.5f; 
            case State.FAST :
                return 3f;
            default:
                Debug.Log("DEFAULTTTTTT SPEED");
                return 3f;  
        }  
    }

    private State Next(State current)
    {
        switch (current)
        {
            case State.IDLE :
                return State.IDLE;
            case State.SLOW :
                return State.IDLE; 
            case State.MID :
                return State.SLOW; 
            case State.FAST :
                return State.MID;
            default:
                Debug.Log("DEFAULTTTTTT NEXT");
                return State.FAST;  
        }
    }
}
