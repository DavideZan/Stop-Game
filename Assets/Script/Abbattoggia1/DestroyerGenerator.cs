using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerGenerator : MonoBehaviour
{
    float startingY; 
    public GameObject destroyerPrefab;

    // Start is called before the first frame update
    void Start() 
    {
        GenerateDestroyer();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount < 1 )
        {
            GenerateDestroyer();
        }
    }

    void GenerateDestroyer()
    {
        GameObject destroyer = Instantiate(destroyerPrefab, new Vector2(0f , startingY), Quaternion.identity, this.gameObject.transform);
        destroyer.GetComponent<SpriteRenderer>().enabled = false;
    }
    
}
