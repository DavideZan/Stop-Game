﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingSceneController : SceneController
{
    protected GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        //Debug.Log("N° WAITING: " + waiting.Count);
        currentIndex = 0;
        saved = new List<int>();
        dead = new List<int>();
    }

    public int GetCurrentPlayerIndex()
    {
        return alive[currentIndex];
    }

    virtual public void GeneratedPlayer()
    {
        currentIndex++;
    }

    public void SavePlayer()
    {
        //Debug.Log("SAVING: " + alive[currentIndex-1]);
        saved.Add(alive[currentIndex-1]);
        //Debug.Log("SAVED: " + saved.Count);
    }

    virtual public void AttackPlayer()
    {   
        if (player == null)
        {
            player =  GameObject.FindGameObjectsWithTag("Player")[0];
        }     
        Destroy(player);
        KillPlayer();
    }

    public bool CanGeneratePlayer()
    {
        //Debug.Log("ALIVE COUNT " + alive.Count);
        return currentIndex < alive.Count;
    }

    public void CheckEnd()
    {
        if (!CanGeneratePlayer()){
            //Debug.Log("SAVED - end : " + saved.Count);
            if (saved.Count > 0){
                GainNewCharacter();
                SaveData();
                LoadNextScene();
            } else {
                SaveData();
                SaveDataForMiddleScene();
                nextScene = "Menu Screen";
                LoadNextScene();
            }
        }
    }

    public void AddScore(int tot)
    {
        score += tot;
    }

    public int GetScore()
    {
        return score;
    }

    private void KillPlayer()
    {
        dead.Add(alive[currentIndex-1]);
        waiting.AddFirst(alive[currentIndex-1]);
    }

    private void GainNewCharacter()
    {
        int gained = waiting.First.Value;
        waiting.RemoveFirst();
        saved.Add(gained);
    }

    override public void LoadNextScene()
    {
        SaveDataForMiddleScene();
        SceneManager.LoadScene("Middle");
    }

    protected virtual void SaveDataForMiddleScene()
    {
        PlayerPrefs.SetString("nextScene", nextScene);
        PlayerPrefs.SetInt("score", score);

        if (saved.Count > 0) {
            PlayerPrefs.SetInt("gained", saved[saved.Count-1]);
        } else {
            PlayerPrefs.DeleteKey("gained");
        }

        if ( SceneManager.GetActiveScene().name == "Boss" && saved.Count > 0){
            PlayerPrefs.SetInt("win", 1);
        } else {
            PlayerPrefs.SetInt("win", 0);
        }
    }
}
