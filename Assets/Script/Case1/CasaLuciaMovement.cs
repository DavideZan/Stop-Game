using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaLuciaMovement : MonoBehaviour
{
    Rigidbody2D rigi;
    public float speed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        rigi = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float newX = Vector2.right.x * speed * Time.deltaTime;
        float newY = newX * Mathf.Cos(Mathf.Deg2Rad * 37.5f); 
        transform.position += new Vector3(newX, newY, 0f);
    }
}
