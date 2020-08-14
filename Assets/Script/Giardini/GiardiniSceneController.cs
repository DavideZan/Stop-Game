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
        //SaveDataForMiddleScene();
        if (chosenPath == Path.Abbatoggia){
            nextScene = nextAbbatoggia;
        } else if (chosenPath == Path.Case){
            nextScene = nextCase;
        }
        base.LoadNextScene();
    }
}
