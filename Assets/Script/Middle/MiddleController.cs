using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MiddleController : SceneController
{
    public string winningTitle;
    public string losingTitle;
    public string middleTitle;
    public Text title;

    public GameObject fullScorePanel;
    public GameObject halfScorePanel;
    public GameObject characterPanel;

    public Text fullScoreText;
    public Text halfScoreText;

    public GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        nextScene = PlayerPrefs.GetString("nextScene");
        if (PlayerPrefs.GetInt("win") == 1){
            InitializeWinningScene();
        } else if (PlayerPrefs.GetInt("gained", -1 ) == -1)
        {
            InitializeLosingScene();
        } else {
            InitializeMiddleScene();
        }
    }

    void InitializeWinningScene()
    {
        title.text = winningTitle;
        InitializeFullScreenScene();
    }

    void InitializeLosingScene()
    {
        title.text = losingTitle;
        InitializeFullScreenScene();
    }

    void InitializeMiddleScene()
    {
        title.text = middleTitle;
        fullScorePanel.SetActive(false);
        halfScorePanel.SetActive(true);
        characterPanel.SetActive(true);
        halfScoreText.text = ""+ PlayerPrefs.GetInt("score"); 
        character.GetComponent<SpriteRenderer>().sprite = GetSpriteFrom(PlayerPrefs.GetInt("gained"));
        character.SetActive(true);
    }

    void InitializeFullScreenScene()
    {
        fullScorePanel.SetActive(true);
        halfScorePanel.SetActive(false);
        characterPanel.SetActive(false);
        character.SetActive(false);
        fullScoreText.text  = ""+ PlayerPrefs.GetInt("score");
        nextScene = "Menu Screen";
    }

    Sprite GetSpriteFrom(int index)
    {
        IndexToPrefab map = GetComponent<IndexToPrefab>();
        GameObject character = map.Map[index];
        return character.GetComponent<SpriteRenderer>().sprite;
    }

    override public void LoadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
