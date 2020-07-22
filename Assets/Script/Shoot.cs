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
        target = GetComponent<Rigidbody2D>().position;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shoot");
            sound.Play();
            Shooting();
        }
    }

    void Shooting()
    {
        RaycastHit2D hit = Physics2D.Raycast(target, -Vector2.up);
        Debug.DrawRay(target, -Vector2.up, Color.red, 10.0f);
        Debug.Log(hit.collider);
        if (hit.collider != null)
        {
            Destroy(hit.collider.gameObject);
        }
    }
}
