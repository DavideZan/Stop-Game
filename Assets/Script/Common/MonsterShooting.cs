using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterShooting : MonoBehaviour
{

    private float remainingTime;
    public float minTimeBtwnShots;
    public float maxTimeBtwnShots;
    public GameObject bullet;
 
    // Start is called before the first frame update
    void Start()
    {
        remainingTime = Random.Range(minTimeBtwnShots, maxTimeBtwnShots);
    }
    // Update is called once per frame
    void Update()

    {
        if (remainingTime <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            remainingTime = Random.Range(minTimeBtwnShots, maxTimeBtwnShots);
        }
        else
        {
            remainingTime -= Time.deltaTime;
        }
    }  
}
