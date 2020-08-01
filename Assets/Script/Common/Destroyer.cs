using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public ShootingSceneController controller;

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            //aggiungere condizioni vite
            controller.SavePlayer();
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start() 
    {
        controller = (ShootingSceneController) FindObjectOfType(typeof(ShootingSceneController));
    }
}
