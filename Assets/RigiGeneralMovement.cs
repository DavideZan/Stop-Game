using UnityEngine;
using System.Collections;

public class RigiGeneralMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float thrust = 10.0f;

    private void Start()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
       
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(transform.up * thrust, ForceMode2D.Impulse);
        }
    }
}