using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyGeneratorGiardini : MonoBehaviour
{
    public float enemyY;
    public float enemyZ;
    int[] spawnX = new int[3] { 0, 2, 9 };
    bool[] posOccupied = new bool[3] { false, false, false };
    [SerializeField] private float myDelay = 1f;
    

    //Random ran = new Random();
    //public float objectOnScreen;
    public GameObject enemyPrefab;
    


    // Start is called before the first frame update
    void Start()
    {
        GenerateEnemy();
    }

    // Update is called once per frame
    /* void Update()
     {
         if (gameObject.transform.childCount < objectOnScreen)
         {
             GenerateEnemy();

         }
     }

     void GenerateEnemy()
     {
         System.Random ran = new System.Random();
         float enemyX = spawn[ran.Next(spawn.Length)];
        GameObject enemy = Instantiate(enemyPrefab, new Vector3(enemyX, enemyY, enemyZ), Quaternion.identity, this.gameObject.transform);
        enemy.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";

     }
     */
    void GenerateEnemy()
    {
        for ( int i = 0; i < posOccupied.Length; i++)
        {
            if (!posOccupied[i])
            {
                GameObject enemy = Instantiate(enemyPrefab, new Vector3(spawnX[i], enemyY, enemyZ), Quaternion.identity, this.gameObject.transform);
                enemy.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
                posOccupied[i] = true;
                Invoke("MyFunction", myDelay);

            }
        }
    }
}

 


