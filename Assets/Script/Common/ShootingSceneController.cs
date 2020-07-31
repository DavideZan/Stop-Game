using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingSceneController : MonoBehaviour
{
    public string nextScene;

    protected DataManager data;
    private int currentIndex;
    private List<int> saved;
    private List<int> dead;
    private int score;
    private List<int> alive;

    // Start is called before the first frame update
    void Start()
    {
        data = (DataManager) FindObjectOfType(typeof(DataManager));
        InitializeScene();
    }

    public void InitializeScene()
    {
        currentIndex = 0;
        saved = new List<int>();
        dead = new List<int>();
        score = data.Score;
        alive = data.Alive;
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
        saved.Add(alive[currentIndex-1]);
    }

    public void KillPlayer()
    {
        dead.Add(alive[currentIndex-1]);
    }

    public bool CanGeneratePlayer()
    {
        return currentIndex < alive.Count;
    }

    public void CheckEnd()
    {
        if (!CanGeneratePlayer()){
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

    private void SaveData(){
        data.Alive = saved.ToList();
        foreach (var d in dead)
        {   
            data.Waiting.AddFirst(d);
        }

        data.Score = data.Score + score;
    }

    virtual public void LoadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

}
