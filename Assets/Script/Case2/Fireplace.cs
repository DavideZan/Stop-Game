using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireplace : ShootableObject
{

    private AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    override public void OnShoot()
    {
        sound.Play();
    }
}
