using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosedBridgeCollision : MonoBehaviour
{
    public ShootingSceneController controller;

    void Start()
    {
        controller = (ShootingSceneController) FindObjectOfType(typeof(ShootingSceneController));
    }

    // called when smth hits the closed bridge
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAA COLLISION");
        Debug.Log("AAAAAAAAAAAAAa " + col.gameObject);
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            controller.KillPlayer();
        }    
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAA COLLISION");
        Debug.Log("AAAAAAAAAAAAAa " + other.gameObject);
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            controller.KillPlayer();
        }
    }
}
