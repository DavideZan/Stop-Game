using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGenerator : MonoBehaviour
{
    public float y = 0f;
    public float x = -9f;
    public SceneController controller;

    private GameObject prefab;
    private GameObject[] map;

    // Start is called before the first frame update
    void Start() 
    {
        map = GetComponent<IndexToPrefab>().Map;
        controller.InitializeScene();
        Generate(controller.GetPlayerIndex());
        controller.GeneratedPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount < 1)
        {
            if (controller.CanGeneratePlayer())
            {
                Generate(controller.GetPlayerIndex());
                controller.GeneratedPlayer();
            }
        }
    }

    void Generate(int index)
    {         
        prefab = map[index];
        Instantiate(prefab, new Vector2(x , y), Quaternion.identity, this.gameObject.transform);
    }
}
