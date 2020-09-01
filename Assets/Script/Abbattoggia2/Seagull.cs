using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seagull : MonoBehaviour
{
    public float speed;
    public float attackTimer;

    private float timeToAttack;
    Rigidbody2D rb;
    ShootingSceneController controller;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        controller = (ShootingSceneController) FindObjectOfType(typeof(ShootingSceneController)); 
        timeToAttack = Random.Range(0f, attackTimer); 
    }

    // Update is called once per frame
    void Update()
    {
        if (timeToAttack < 0){
            Debug.Log("AATAAAAACK");
            PointToPlayer();
        } else {
            timeToAttack -= Time.deltaTime;
            NormalMovement();
        }
    }

    void NormalMovement()
    {
        rb.AddForce(transform.right * speed * Time.deltaTime);
    }

    void PointToPlayer()
    {
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        if (player != null){
            Vector3 dir = player.position - transform.position;
            float angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg + 180;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);        
            rb.AddForce(transform.right * speed * Time.deltaTime);        
            }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            controller.AttackPlayer();
            Destroy(gameObject);
        } 
        else
        {
            Destroy(gameObject); 
        }
    }
}
