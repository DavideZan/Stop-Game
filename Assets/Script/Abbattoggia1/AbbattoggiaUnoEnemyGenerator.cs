using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbbattoggiaUnoEnemyGenerator : EnemyGenerator
{
    override protected void NewEnemy()
    {
        float enemyY = Mathf.Floor(Random.Range(minY, maxY));
        float enemyX = Mathf.Floor(Random.Range(minX, maxX));
        GameObject enemy = Instantiate(enemyPrefab, new Vector2(enemyX , enemyY), Quaternion.identity, this.gameObject.transform);
        enemy.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
        enemy.layer = 9;
        Physics2D.IgnoreLayerCollision(9,10);
    }
}
