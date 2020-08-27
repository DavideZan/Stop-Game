using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeloxGenerator : MonoBehaviour
{

    public float enemyX = 0;
    public float enemyY = 0f;
    public float objectOnScreen;
    public GameObject enemyPrefab;
    //private float VeloxCounter = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //if (VeloxCounter == 1f)
        GenerateEnemy();
        //VeloxCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount < objectOnScreen)
        {
            GenerateEnemy();
        }
    }

    virtual protected void GenerateEnemy()
    {
        
        GameObject enemy = Instantiate(enemyPrefab, new Vector2(enemyX, enemyY), Quaternion.identity, this.gameObject.transform);
        enemy.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
        enemy.layer = 10;
    }
}
