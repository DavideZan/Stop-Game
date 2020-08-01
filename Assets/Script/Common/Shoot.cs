using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float reloadTime = 1f;
    public ScoreScript scoreScript;

    Vector2 target;
    AudioSource sound;
    bool canShoot;

    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
        target = GetComponent<Rigidbody2D>().position;
        sound = GetComponent<AudioSource>();
        scoreScript = (ScoreScript) FindObjectOfType(typeof(ScoreScript));
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
            //Debug.Log(hit.collider);
            if (hit.collider != null)
            {
                //if a button is being shot
                if (hit.collider.GetComponent<CommonButton>() != null)
                {
                    hit.collider.GetComponent<CommonButton>().PressButton();
                }
                else if (hit.collider.tag == "Player")
                {
                    var controller = (ShootingSceneController) FindObjectOfType(typeof(ShootingSceneController));
                    Destroy(hit.collider.gameObject);
                    controller.KillPlayer();

                } else if (hit.collider.GetComponent<BulletScript>() != null)
                {
                    Destroy(hit.collider.gameObject);
                    scoreScript.AddPoints(50);
                } 
                else
                {
                    Destroy(hit.collider.gameObject);
                    scoreScript.AddPoints(100);
                }
            }
            else {
                canShoot = false;
                //Debug.Log(canShoot);
                StartCoroutine(ReloadTimer());
            }
        }
    }

    private IEnumerator ReloadTimer()
    {
        float reloadTime = 1f;
        float elapsed = 0f;
        while (elapsed <= reloadTime)
        {
            elapsed += Time.deltaTime;
            yield return null;
        }
        canShoot = true;
        yield return null;
    }
}