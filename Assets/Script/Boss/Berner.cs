using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berner : ShootableObject
{

    override public void OnShoot(){
        Destroy(gameObject.transform.parent.gameObject);
    }

}
