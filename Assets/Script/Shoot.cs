using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    Vector2 target;
    AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<Rigidbody2D>().position;
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shoot");
            sound.Play();
        }
    }
}
