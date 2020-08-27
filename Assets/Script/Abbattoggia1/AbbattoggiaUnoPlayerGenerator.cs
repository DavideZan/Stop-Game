using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbbattoggiaUnoPlayerGenerator : PlayerGenerator
{
    public GameObject platePrefab;

    override protected void Generate(int index)
    {         
        prefab = map[index];
        GameObject player = Instantiate(prefab, new Vector2(x , y), _rotation, this.gameObject.transform);
        player.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
        player.GetComponent<GeneralMovement>().enabled = false;
        player.layer = 9;

        var plate = Instantiate(platePrefab,
                    player.transform.position,
                    Quaternion.identity,
                    player.transform);
        plate.transform.localPosition = new Vector3(8f, 3f, 0f);
        plate.transform.localScale = new Vector3(50f, 50f, 0f);
        plate.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
        plate.GetComponent<SpriteRenderer>().sortingOrder = 1;
        plate.layer = 9;

        Physics2D.IgnoreLayerCollision(9,10);
    }
}
