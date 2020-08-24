using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeloxScript : MonoBehaviour


{
    public AbbattoggiaUnoController controller;
    public bool veloxAttivo;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player" && veloxAttivo)
        {
            controller.VeloxNull();
        }
    }

  


    // Start is called before the first frame update
    void Start()
    {
        controller = (AbbattoggiaUnoController)FindObjectOfType(typeof(AbbattoggiaUnoController));
        veloxAttivo = true; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
