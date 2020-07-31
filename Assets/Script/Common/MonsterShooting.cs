using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterShooting : MonoBehaviour
{

    private float timeBtwShots;
    public float startTimeBtwnShots;
    public GameObject Bullet;
    

  

    // Start is called before the first frame update
    void Start()
    {
        timeBtwShots = startTimeBtwnShots;
    }
    // Update is called once per frame
    void Update()

    {
        if (timeBtwShots <=0)
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwnShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
     
    
}
