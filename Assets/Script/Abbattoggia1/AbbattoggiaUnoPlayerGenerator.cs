using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbbattoggiaUnoPlayerGenerator : PlayerGenerator
{
    public GameObject platePrefab;
    public GameObject carPrefab;

    override protected void Generate(int index)
    {         
/*         prefab = map[index];
        GameObject player = Instantiate(prefab, new Vector2(x , y), _rotation, this.gameObject.transform);
        player.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
        player.GetComponent<GeneralMovement>().enabled = false;
        player.layer = 9;
 */
        GameObject car = Instantiate(carPrefab, new Vector2(x , y), _rotation, this.gameObject.transform);
        car.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
        car.GetComponent<SpriteRenderer>().sortingOrder = 1;
        car.layer = 9;
        car.tag = "Player";

        var plate = Instantiate(platePrefab,
                    car.transform.position,
                    //new Vector3(1f,1f,1f),
                    Quaternion.identity,
                    car.transform);
        plate.transform.localPosition = new Vector3(21.1f, -16.03f, 0f);
        plate.transform.localScale = new Vector3(50f, 50f, 0f);
        plate.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
        plate.GetComponent<SpriteRenderer>().sortingOrder = 2;
        plate.layer = 9;

        Physics2D.IgnoreLayerCollision(9,10);
    }
}
