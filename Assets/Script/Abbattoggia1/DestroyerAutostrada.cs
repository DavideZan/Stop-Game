using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerAutostrada : Destroyer
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            //aggiungere condizioni vite
            controller.SavePlayer();
            Destroy(gameObject);
        }
        else
        {
            //Nothing
        }
    }   
}

