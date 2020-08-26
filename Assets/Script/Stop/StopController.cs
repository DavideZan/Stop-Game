using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopController : ShootingSceneController
{
    public GameObject haloShotgunPrefab;

    public void GainHaloShotgun()
    {
        player =  GameObject.FindGameObjectsWithTag("Player")[0];
        GameObject haloShotgun = Instantiate(haloShotgunPrefab, 
                                                player.transform.position, 
                                                Quaternion.Euler(0f, 180f, 0f),
                                                player.transform);
        haloShotgun.transform.localPosition = new Vector3(3f,0f,0f);
        haloShotgun.transform.localScale = new Vector3(.4f,.4f,1f);
        haloShotgun.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
    }

    public override void AttackPlayer()
    {
            player =  GameObject.FindGameObjectsWithTag("Player")[0];
        if (player.transform.childCount == 0) {
            Debug.Log("NO CHILDREN");
            base.AttackPlayer();
        } else {
            Debug.Log("Destroyed gun");
            Destroy(player.transform.GetChild(0).gameObject);
        }
    }

    protected void RemoveHaloShotgun()
    {
        player =  GameObject.FindGameObjectsWithTag("Player")[0];
        Destroy(player.transform.GetChild(0).gameObject);
    }
}
