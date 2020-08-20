using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaloShotgun : ShootableObject
{
    public StopController controller;

    void Start() {
        controller = (StopController) FindObjectOfType(typeof(StopController));    
    }

    override public void OnShoot()
    {
        controller.GainHaloShotgun();
        gameObject.SetActive(false);
    }
}
