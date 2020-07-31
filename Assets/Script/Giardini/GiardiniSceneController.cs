using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GiardiniSceneController : ShootingSceneController
{

    public string nextAbbatoggia;
    public string nextCase;

    override public void LoadNextScene()
    {
        if (chosenPath == Path.Abbatoggia){
            SceneManager.LoadScene(nextAbbatoggia);
        } else if (chosenPath == Path.Case){
            SceneManager.LoadScene(nextCase);
        }
    }
}
