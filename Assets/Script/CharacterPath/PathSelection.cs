using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PathSelection : LoadSceneButton
{
    public Path chosenPath;
    public CharacterPathController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = (CharacterPathController) FindObjectOfType(typeof(CharacterPathController));
    }

    override public void PressButton()
    {
        controller.SetPath(chosenPath);
        controller.SetScene(sceneName);
        controller.LoadNextScene();
        // Debug.Log("AAAAAAAAAAAAAA " + sceneName);
        // SceneManager.LoadScene(sceneName);
    }
}
