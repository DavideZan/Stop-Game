using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeloxScript : MonoBehaviour
{
    public bool veloxAttivo;
    public AbbattoggiaUnoController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = (AbbattoggiaUnoController)FindObjectOfType(typeof(AbbattoggiaUnoController));
        Physics2D.IgnoreLayerCollision(9,10);
        veloxAttivo = true;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];
        CheckPlayerPosition(player);
    }

    private void CheckPlayerPosition(GameObject player)
    {
        if (player.transform.position.x - transform.position.x < 1 &&
            player.transform.position.y - transform.position.y < 1 &&
            veloxAttivo)
        {
            controller.VeloxNull();
        }
    }

    public void SetActive(bool b)
    {
        veloxAttivo = b;
    }
}
