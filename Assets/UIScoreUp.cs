using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreUp : MonoBehaviour {

    public GameObject ScoreHold;
    Text Score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<UnityEngine.UI.Text>().text = ScoreHold.GetComponent<PlayerScore>().score.ToString();
            // = gameObject.GetComponent<UnityEngine.UI.Text>();
	}
}
