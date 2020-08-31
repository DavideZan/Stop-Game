using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public float minY = -5f;
    public float maxY = 4f;
    public float minX = -9f;
    public float maxX = 9f;
    public float objectOnScreen;
    public GameObject enemyPrefab;
    public float minGenerationTimeout = 0f;
    public float maxGenerationTimeout = 0f;

    private bool generationSemaphore;

    // Start is called before the first frame update
    void Start() 
    {
        GenerateEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount < objectOnScreen && generationSemaphore)
        {
            StartCoroutine(GenerateEnemyTimer());
            generationSemaphore = false;
        }
    }

    void GenerateEnemy()
    {
        NewEnemy();
        generationSemaphore = true;
    }

    virtual protected void NewEnemy()
    {
        float enemyY = Mathf.Floor(Random.Range(minY, maxY));
        float enemyX = Mathf.Floor(Random.Range(minX, maxX));
        GameObject enemy = Instantiate(enemyPrefab, new Vector2(enemyX , enemyY), Quaternion.identity, this.gameObject.transform);
        enemy.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
    }

    IEnumerator GenerateEnemyTimer()
    {
        float duration = Random.Range(minGenerationTimeout, maxGenerationTimeout);
        while(duration >= 0f)
        {
            yield return null;
            duration -= Time.deltaTime;
        }
        GenerateEnemy();
        yield return null;
    }
}
