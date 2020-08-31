using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolgaridaEnemyGenerator : EnemyGenerator
{ 
    //TODO: enemyPrefab is to be chosen from a list of animations
    override protected void NewEnemy()
    {
        float enemyY = Random.Range(minY, maxY);
        float enemyX = Random.Range(minX, maxX);
        GameObject enemy = Instantiate(enemyPrefab, new Vector2(enemyX , enemyY), Quaternion.identity, this.gameObject.transform);
        enemy.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
        enemy.transform.localScale = new Vector3(0.03f, 0.03f, 1f);
    }
}
