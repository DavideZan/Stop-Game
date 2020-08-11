using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiteTailShooting : ShootableObject
{
    public override void OnShoot()
    {
        Destroy(gameObject.transform.parent.gameObject);
    } 
}
