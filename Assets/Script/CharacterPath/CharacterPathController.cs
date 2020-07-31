using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CharacterPathController : SceneController
{
    public SelectorScript selector;

    // Start is called before the first frame update
    void Start()
    {
        saved = new List<int>();
        dead = new List<int>();
        score = 0;
        waiting = new LinkedList<int>();
    }

    public void SetPath(Path p){
        //TODO: actual implementation with a button
        SetCharacter(selector.ChosenCharacter);
        chosenPath = p;
    }

    public void SetScene(string s){
        nextScene = s;
    }

    public void SetCharacter(int i){
        saved = new List<int>(i);
        waiting = GenerateWaitingExcluding(i);
    }

    private LinkedList<int> GenerateWaitingExcluding(int i) 
    {
        int[] waits = Enumerable.Range(1, 10)
                                .Where((e, _) => e != i)
                                .OrderBy(x => Random.Range(0f,1f))
                                .ToArray();
        return new LinkedList<int>(waits);
    }
}
