using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //This is the basic code from the book. Only moves it on X axis, ask Mundell about it.
        //Get Current screen position from mouse input
        Vector3 mousePos2D = Input.mousePosition;

        //The camera z position sets how far to push the mouse int 3d ??
        mousePos2D.z = -Camera.main.transform.position.z;

        //Convert the point from 2d screen space into 3d game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        //Move the x position of this basket to the x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

	}
}
