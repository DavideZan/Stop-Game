using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thermometer : MonoBehaviour
{

    public Sprite[] sprites;

    private SpriteRenderer current;
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        current = gameObject.GetComponent<SpriteRenderer>();
        sound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetTemperature(State state)
    {
        switch (state)
        {
            case State.IDLE :
                current.sprite = sprites[0];
                sound.Play();
                break;
            case State.SLOW :
                current.sprite = sprites[1];
                break;
            case State.MID :
                current.sprite = sprites[2];
                break;
            case State.FAST :
                current.sprite = sprites[3];
                break;
            default:
                Debug.Log("DEFAULTTTTTT SPRITE");
                current.sprite = sprites[3];
                break;

        }
        if (state != State.IDLE){
            sound.Stop();
        }  
    }
}
