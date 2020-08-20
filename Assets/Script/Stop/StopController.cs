using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopController : ShootingSceneController
{
    public GameObject haloShotgunPrefab;

    public void GainHaloShotgun()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject haloShotgun = Instantiate(haloShotgunPrefab, 
                                                player.transform.position, 
                                                Quaternion.Euler(0f, 180f, 0f),
                                                player.transform);
        haloShotgun.transform.localPosition = new Vector3(3f,0f,0f);
        haloShotgun.transform.localScale = new Vector3(.4f,.4f,1f);
        haloShotgun.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
    }
        
    protected void RemoveHaloShotgun()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Destroy(player.transform.GetChild(0));
    }
}
