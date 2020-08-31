using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownbridgeDestroyer : MonoBehaviour
{
    public ShootingSceneController controller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            //aggiungere condizioni vite
            controller.SavePlayer();
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    virtual protected void Init()
    {
        controller = (ShootingSceneController)FindObjectOfType(typeof(ShootingSceneController));
    }
}
