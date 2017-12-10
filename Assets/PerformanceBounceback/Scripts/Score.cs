using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
    private Text text;
    int previousScore = 0;
    // Use this for initialization
    void Start () {
         text = GetComponentInChildren<Text>();
    }
	
   	// Update is called once per frame
	void Update () {
        //update only if previous score not equal to the current score
        if ( previousScore != gameManager.score )
        {
            text.text = "Score: " + gameManager.score.ToString();
            previousScore = gameManager.score;
        }
       
    }
}
