using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionExampleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Physical Collision to Wrap here?");
    }
}
