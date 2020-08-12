using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiteTailShooting : ShootableObject
{
    public float force = 1f;

    public override void OnShoot()
    {
        var kite = gameObject.transform.parent.gameObject;
        var f = kite.AddComponent<ConstantForce2D>();
        f.force = Vector2.up * force;

        Destroy(gameObject);
    } 
}
