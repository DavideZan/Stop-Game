using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float reloadTime = 1f;

    Vector2 target;
    AudioSource sound;
    bool canShoot;

    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
        target = GetComponent<Rigidbody2D>().position;
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        target = GetComponent<Rigidbody2D>().position;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shooting();
        }
    }

    void Shooting()
    {
        if (canShoot)
        {
            sound.Play();
            RaycastHit2D hit = Physics2D.Raycast(target, -Vector2.up);
            Debug.Log(hit.collider);
            if (hit.collider != null)
            {
                Destroy(hit.collider.gameObject);
            }
        canShoot = false;
        Debug.Log(canShoot);
        StartCoroutine(ReloadTimer());
        }
    }

    private IEnumerator ReloadTimer()
    {
        float reloadTime = 1f; 
        float elapsed = 0f;
        while(elapsed <= reloadTime)
        {
            elapsed += Time.deltaTime;
            yield return null;
        }  
        canShoot = true;
        yield return null;
    }
}
