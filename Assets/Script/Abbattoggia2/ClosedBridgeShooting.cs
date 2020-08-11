using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosedBridgeShooting : ShootableObject
{
    public GameObject openShip;

    public override void OnShoot()
    {
        openShip.SetActive(true);
        gameObject.transform.parent.gameObject.SetActive(false);
    } 
}
