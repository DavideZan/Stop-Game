﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buddhet : MonoBehaviour
{
    ShootingSceneController controller;


    // Start is called before the first frame update
    void Start()
    {
        controller = (ShootingSceneController) FindObjectOfType(typeof(ShootingSceneController));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            controller.KillPlayer();
        }
        Destroy(gameObject);
    }
}
