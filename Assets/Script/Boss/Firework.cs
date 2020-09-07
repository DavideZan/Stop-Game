using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firework : MonoBehaviour
{

    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        gameObject.SetActive(true);
        sound.Play();
    }
}
