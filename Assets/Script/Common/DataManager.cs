using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager sceneController;

    private int score;
    public int Score { get => score; set => score = value; }
    private List<int> alive;
    public List<int> Alive { get => alive; set => alive = value; } 
    private LinkedList<int> waiting;
    public LinkedList<int> Waiting { get => waiting; set => waiting = value; }
    private Path chosenPath;
    public Path ChosenPath { get => chosenPath; set => chosenPath = value; }


    void Awake(){
        //Let the gameobject persist over the scenes
        DontDestroyOnLoad(gameObject);
        //Check if the control instance is null
        if (sceneController == null)
        {
            //This instance becomes the single instance available
            sceneController = this;
        }
        //Otherwise check if the control instance is not this one
        else if (sceneController != this)
        {
            //In case there is a different instance destroy this one.
            Destroy(gameObject);
        }
    }

    public void SetupEverything(int chosenCharacter, Path chosenPath)
    {
        score = 0;
        alive = new List<int>();
        alive.Add(chosenCharacter);
        int[] range = {1,2,3,4,5,6,7,8,9,10,11,12};
        waiting = new LinkedList<int>(range);
        this.chosenPath = chosenPath;
    }

}
