using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMove : MonoBehaviour {

    public float speed = 0.1f;
	// Use this for initialization
	void Start () {
        Debug.Log("Hello World!");
        print("Goodbye fun guy!");
	}
	
	// Update is called once per frame
	void Update () {
        //gameObject.transform.

        //Debug.Log(gameObject.transform.position.x + " " + gameObject.transform.position.y);
        //Invalid gameObject.transform.position.x + 10;
        

        if (Input.GetKey(KeyCode.D) && gameObject.transform.position.x < 9)
        {
            gameObject.transform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += new Vector3(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position += new Vector3(0, -speed, 0);
        }
    }
}
