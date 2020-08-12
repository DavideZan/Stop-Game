using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasaLuciaPlayerGenerator : PlayerGenerator
{
    override protected void Generate(int index)
    {         
        prefab = map[index];
        GameObject player = Instantiate(prefab, new Vector2(x , y), _rotation, this.gameObject.transform);
        player.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
        player.GetComponent<GeneralMovement>().enabled = false;
        player.AddComponent<CasaLuciaMovement>().enabled = true;
    }
}
