using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

    public int score;
    public Text scoreText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeScore(int Points)
    {
        score += Points;
        Debug.Log("Score: " + score);
        scoreText.text = score.ToString();
    }

    
}
