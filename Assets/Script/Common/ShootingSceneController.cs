using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingSceneController : SceneController
{
    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        currentIndex = 0;
        saved = new List<int>();
        dead = new List<int>();
    }

    public int GetCurrentPlayerIndex()
    {
        return alive[currentIndex];
    }

    public void GeneratedPlayer()
    {
        currentIndex++;
    }

    public void SavePlayer()
    {
        //Debug.Log("SAVING: " + alive[currentIndex-1]);
        saved.Add(alive[currentIndex-1]);
        //Debug.Log("SAVED: " + saved.Count);
    }

    public void KillPlayer()
    {
        dead.Add(alive[currentIndex-1]);
        waiting.AddFirst(alive[currentIndex-1]);
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
                SaveData();
                LoadNextScene();
            } else {
                SaveData();
                SceneManager.LoadScene("Menu Screen");
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
}
