using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterShooting : MonoBehaviour
{

    private float remainingTime;
    public float startTimeBtwnShots;
    public GameObject bullet;
 
    // Start is called before the first frame update
    void Start()
    {
        remainingTime = startTimeBtwnShots;
    }
    // Update is called once per frame
    void Update()

    {
        if (remainingTime <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            remainingTime = startTimeBtwnShots;
        }
        else
        {
            remainingTime -= Time.deltaTime;
        }
    }  
}
