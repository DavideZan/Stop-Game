using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour
{
    ShootingSceneController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = (ShootingSceneController) FindObjectOfType(typeof(ShootingSceneController));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            controller.AttackPlayer();
        }
    }
}
