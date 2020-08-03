using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorScript : MonoBehaviour
{
    public Vector3 visiblePosition;
    public CharacterPathController controller;

    private int characterIndex = 0;
    private IndexToPrefab map;
    private GameObject currentPrefab;

    void Start() {
        controller = (CharacterPathController) FindObjectOfType(typeof(CharacterPathController));
        map = GetComponent<IndexToPrefab>();
        ShowCurrentPrefab();
    }

    public void RightCharacter()
    {
        Destroy(currentPrefab);
        characterIndex = moveRight(characterIndex);
        ShowCurrentPrefab();
        controller.SetCharacter(characterIndex);
    }

    public void LeftCharacter()
    {
        Destroy(currentPrefab);
        characterIndex = moveLeft(characterIndex);
        ShowCurrentPrefab();
        controller.SetCharacter(characterIndex);
    }
     
    private int moveRight(int i){
        return (i+1) % map.Map.Length;
    }

    private int moveLeft(int i){
        return i = (i-1) < 0 ? (map.Map.Length-1) : i-1;
    }

    private void ShowCurrentPrefab()
    {
        GameObject character = map.Map[characterIndex];
        currentPrefab = Instantiate(character, visiblePosition, Quaternion.identity);  
        currentPrefab.GetComponent<GeneralMovement>().enabled = false;
        currentPrefab.GetComponent<BoxCollider2D>().enabled = false;
    }
}
