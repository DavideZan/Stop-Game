using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiteGenerator : EnemyGenerator
{
    override protected void GenerateEnemy()
    {
        float enemyY = Random.Range(minY, maxY);
        float enemyX = Random.Range(minX, maxX);
        GameObject enemy = Instantiate(enemyPrefab, new Vector2(enemyX , enemyY), Quaternion.Euler(0f,0f,45f), this.gameObject.transform);
        enemy.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
    }
}
