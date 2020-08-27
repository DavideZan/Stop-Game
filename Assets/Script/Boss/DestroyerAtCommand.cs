using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerAtCommand : Destroyer
{
    public bool savePlayer;

    override protected void Init()
    {
        savePlayer = false;
        base.Init();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (savePlayer){
            Destroy(collision.gameObject);
            controller.SavePlayer();
            }
            else {
                Destroy(collision.gameObject);
                controller.AttackPlayer();
            }
        }
    }
}
