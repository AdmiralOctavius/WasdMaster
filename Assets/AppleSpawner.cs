using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour {

    // Use this for initialization
    //GameObjects
    public GameObject objToSpawn;

    //Variables
    float spawnTime = float.MinValue;
    public float timeBetweenSpawn = 3;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Time.time - spawnTime >= timeBetweenSpawn)
        {
            spawnTime = Time.time;
            GameObject newApple = Instantiate(objToSpawn, gameObject.transform.position, Quaternion.identity);
            newApple.transform.position += new Vector3(Random.Range(-8f,8f), 0, 0);
        }
	}
}
