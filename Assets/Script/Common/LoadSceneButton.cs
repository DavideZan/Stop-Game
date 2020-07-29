using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadSceneButton : CommonButton
{

    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override public void PressButton()
    {
        Debug.Log("AAAAAAAAAAAAAA " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
