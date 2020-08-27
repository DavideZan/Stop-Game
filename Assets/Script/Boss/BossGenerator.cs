using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGenerator : MonoBehaviour
{
    public GameObject bernerPrefab;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float bossMovementTime;

    public BossController controller;

    private float remainingTimeToBossMovement;
    private GameObject[] map;
    private bool instantiateNewBoss;

    // Start is called before the first frame update
    void Start()
    {
        controller = (BossController) FindObjectOfType(typeof(BossController));
        instantiateNewBoss = true;
    }

    // Update is called once per frame
    void Update(){
        if (gameObject.transform.childCount == 0 && instantiateNewBoss){
            GenerateBoss();
        } else {
            CheckSceneContitions();
        }
    }

    void GenerateBoss(){
        map = GetComponent<IndexToPrefab>().Map;
        var bossCharacterPrefab = map[controller.GetBossIndex()];
        InstantiateBoss(bossCharacterPrefab);
        remainingTimeToBossMovement = bossMovementTime;
        instantiateNewBoss = false;
    }

    void CheckSceneContitions(){
        if (gameObject.transform.childCount == 0){
            controller.StartFireworks();
        } else{
            CheckIfBossIsMoving();
        }
    }

    void CheckIfBossIsMoving(){
        if (remainingTimeToBossMovement <= 0){
            MoveBoss();
            remainingTimeToBossMovement = bossMovementTime;
        } else {
            remainingTimeToBossMovement -= Time.deltaTime;
        }
    }

    void InstantiateBoss(GameObject bossCharacterPrefab){
        GameObject boss = Instantiate(bossCharacterPrefab, 
                    new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)), 
                    Quaternion.identity, 
                    gameObject.transform);
        boss.gameObject.tag = "Untagged";
        var bossScript = boss.gameObject.AddComponent(typeof(Boss)) as Boss;
        var hitPlayer = boss.gameObject.AddComponent(typeof(HitPlayer)) as HitPlayer;
        boss.gameObject.GetComponent<GeneralMovement>().enabled = false;
        boss.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";


        var berner = Instantiate(bernerPrefab,
                    boss.transform.position,
                    Quaternion.identity,
                    boss.transform);
        berner.transform.localPosition = new Vector3(-5f, 3f, 0f);
        berner.GetComponent<SpriteRenderer>().sortingLayerName = "Entities";
    }

    void MoveBoss(){
        var boss = (Boss) FindObjectOfType(typeof(Boss));
        boss.gameObject.transform.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }
}
