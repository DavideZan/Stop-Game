﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CharacterPathController : SceneController
{
    // Start is called before the first frame update
    void Start()
    {
        saved = new List<int>();
        dead = new List<int>();
        score = 0;
        waiting = new LinkedList<int>();
    }

    public void SetPath(Path p){
        chosenPath = p;
    }

    public void SetScene(string s){
        nextScene = s;
    }

    public void SetCharacter(int i){
        saved.Clear(); 
        saved.Add(i);
        //Debug.Log("SET CHARACTER: SAVED COUNT " + saved.Count);
        waiting = GenerateWaitingExcluding(i);
    }
    public override void LoadNextScene(){
        SaveData();
        base.LoadNextScene();
    }

    private LinkedList<int> GenerateWaitingExcluding(int i) 
    {
        int[] waits = Enumerable.Range(0, 12)
                                .Where((e, _) => e != i)
                                .OrderBy(x => Random.Range(0f,1f))
                                .ToArray();
        return new LinkedList<int>(waits);
    }
}
