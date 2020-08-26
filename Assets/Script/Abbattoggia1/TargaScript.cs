using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargaScript : ShootableObject
{
    public AbbattoggiaUnoController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = (AbbattoggiaUnoController)FindObjectOfType(typeof(AbbattoggiaUnoController));
    }

    public override void OnShoot()
    {
        controller.ShootPlate();
        Debug.Log("AAAAO");
    }
}

