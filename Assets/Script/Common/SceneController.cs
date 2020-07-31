using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class SceneController : MonoBehaviour
{
    public string nextScene;

    protected int currentIndex;
    protected List<int> saved;
    protected List<int> dead;
    protected int score;
    protected List<int> alive;

    protected LinkedList<int> waiting;
    protected Path chosenPath;

    virtual protected void SaveData(){
        string gameData = JsonUtility.ToJson(new GameData(score, saved, waiting.ToList(), chosenPath));
        System.IO.File.WriteAllText(Application.persistentDataPath + "/gameData.json", gameData);
    }

    virtual protected void LoadData(){
        GameData gameData = JsonUtility.FromJson<GameData>(System.IO.File.ReadAllText(Application.persistentDataPath + "/gameData.json"));
        score = gameData.score;
        alive = gameData.alive;
        waiting = new LinkedList<int>(gameData.waiting.ToArray());
        chosenPath = gameData.chosenPath;
    }

    virtual public void LoadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    [System.Serializable]
    class GameData{
        public int score;
        public List<int> alive;
        public List<int> waiting;
        public Path chosenPath;

        public GameData(int s,List<int> a, List<int> w, Path c) {
            score = s;
            alive = a;
            waiting = w;
            chosenPath = c;
        }
    }
}
