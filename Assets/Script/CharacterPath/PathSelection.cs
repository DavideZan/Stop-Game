using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PathSelection : LoadSceneButton
{
    public SelectorScript selector;
    public Path chosenPath;
    private DataManager data;

    // Start is called before the first frame update
    void Start()
    {
        data = (DataManager) FindObjectOfType(typeof(DataManager));
        // if (data != null){
        //     Debug.Log("FOUUUND");
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override public void PressButton()
    {
        data.SetupEverything(selector.ChosenCharacter, chosenPath);
        Debug.Log("AAAAAAAAAAAAAA " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
