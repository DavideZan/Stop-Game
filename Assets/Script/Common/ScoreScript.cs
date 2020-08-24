using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public int scoreValue;
    Text score;
    public ShootingSceneController controller;

    private string fixedText;


    // Start is called before the first frame update
    void Start()
    {
        controller = (ShootingSceneController)FindObjectOfType(typeof(ShootingSceneController));
        score = GetComponent<Text>();
        scoreValue = controller.GetScore();
        fixedText = score.text;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = fixedText + scoreValue.ToString();
    }

    public void AddPoints(int tot)
    {
        scoreValue += tot;
        controller.AddScore(tot);
    }
    public void VeloxNull()
    {
        scoreValue = 0;
        
    }
}