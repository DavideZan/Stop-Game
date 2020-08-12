using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBuddha : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float magnitude = 1f;
    public float delay;


    private bool canShoot;

    // Start is called before the first frame update
    void Start()
    {
        canShoot = false;    
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot){
            Shoot();
            canShoot = false;
            StartCoroutine(Reload());
        }
    }

    void Shoot()
    {
        //instantiate and shoot
        var bullet = Instantiate(bulletPrefab, gameObject.transform.position, Quaternion.identity);

        //point to go: bottom left is (-5.35, -4.92), top right is (9.55, 3.85)
        var finalX = Random.Range(-5.3f, 9.5f);
        var finalY = (finalX+5.3f) * Mathf.Sin(Mathf.Deg2Rad * 37.5f);

         // Defaults
        Vector2 direction = new Vector3(finalX, finalY, 0f) - gameObject.transform.position ;
        
        // Add the stuff
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D> ();
        
        // Add force
        rb.AddRelativeForce(direction * magnitude, ForceMode2D.Impulse);
    }

    IEnumerator Reload()
    {
        var reloadingTime = delay;
        while (reloadingTime >= 0)
        {
            reloadingTime -= Time.deltaTime;
            yield return null;
        }
        canShoot = true;
    }
}
