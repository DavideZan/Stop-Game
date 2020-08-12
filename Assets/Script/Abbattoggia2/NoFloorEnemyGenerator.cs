using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoFloorEnemyGenerator : EnemyGenerator
{
    override protected void GenerateEnemy()
    {
        float enemyY = Random.Range(minY, maxY);
        float enemyX = Random.Range(minX, maxX);
        GameObject enemy = Instantiate(enemyPrefab, new Vector2(enemyX , enemyY), Quaternion.identity, this.gameObject.transform);
        enemy.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
    }
}
