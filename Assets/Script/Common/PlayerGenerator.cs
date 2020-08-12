using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGenerator : MonoBehaviour
{
    public float y = 0f;
    public float x = -9f;
    public ShootingSceneController controller;

    protected GameObject prefab;
    protected GameObject[] map;
    protected Quaternion _rotation = Quaternion.identity;
    public Quaternion rotation {
        get => _rotation;
        set => _rotation = value;
    }

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

    virtual protected void Generate(int index)
    {         
        prefab = map[index];
        GameObject player = Instantiate(prefab, new Vector2(x , y), _rotation, this.gameObject.transform);
        player.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
    }
}
