using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGenerator : MonoBehaviour
{
    public float y = 0f;
    public float x = -9f;
    public ShootingSceneController controller;

    private GameObject prefab;
    private GameObject[] map;

    // Start is called before the first frame update
    void Start() 
    {
        map = GetComponent<IndexToPrefab>().Map;
        controller = (ShootingSceneController) FindObjectOfType(typeof(ShootingSceneController));
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount < 1)
        {
            if (controller.CanGeneratePlayer())
            {
                Generate(controller.GetCurrentPlayerIndex());
                controller.GeneratedPlayer();
            } else {
                controller.CheckEnd();
            }
        }
    }

    void Generate(int index)
    {         
        prefab = map[index];
        GameObject player = Instantiate(prefab, new Vector2(x , y), Quaternion.identity, this.gameObject.transform);
        player.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
    }
}
