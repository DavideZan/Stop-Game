using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectionButton : CommonButton
{

    public SelectorScript selector;

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
        if (gameObject.tag == "left")
        {
            selector.LeftCharacter();
        } else
        {
            selector.RightCharacter();
        }
    }

}
