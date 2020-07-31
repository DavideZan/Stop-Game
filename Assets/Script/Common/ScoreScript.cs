using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public int scoreValue;
    Text score;
    public ShootingSceneController controller;


    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        scoreValue = controller.GetScore();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = scoreValue.ToString();
    }

    public void AddPoints(int tot)
    {
        scoreValue += tot;
        controller.AddScore(tot);
    }
}