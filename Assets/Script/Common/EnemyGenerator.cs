using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    public float minY = -5f;
    public float maxY = 4f;
    public float enemyX = 0f;
    public float objectOnScreen;
    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start() 
    {
        GenerateEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount <= objectOnScreen-1)
        {
            GenerateEnemy();
        }
    }

    void GenerateEnemy()
    {
         
         float enemyY = Mathf.Floor(Random.Range(minY, maxY));
         GameObject enemy = Instantiate(enemyPrefab, new Vector2(enemyX , enemyY), Quaternion.identity, this.gameObject.transform);
    }
}
