using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : LoadSceneButton
{

    public MiddleController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = (MiddleController) FindObjectOfType(typeof(MiddleController));
    }

    override public void PressButton()
    {
        controller.LoadNextScene();
    }
}
