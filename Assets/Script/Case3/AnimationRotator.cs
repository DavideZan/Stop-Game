using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var players = GameObject.FindGameObjectsWithTag("Player");
        if (players.Length > 0) {
            var player = players[0];
            if (player != null){
                if (transform.position.x < player.transform.position.x){
                    transform.rotation = Quaternion.Euler(0f,180f,0f);
                }
            }
        }
    }
}
