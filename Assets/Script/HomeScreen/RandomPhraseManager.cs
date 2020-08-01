using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomPhraseManager : MonoBehaviour
{
    [TextArea]
    public string[] phrases;
    private Text box;

    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<Text>();
        var n = Random.Range(0, phrases.Length);
                //7;
        box.text = phrases[n];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
