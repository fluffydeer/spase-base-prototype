using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotategalaxy : MonoBehaviour {
    public GameObject center;
    public float rychlost;
   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        OrbitAround();
    }

    void OrbitAround()
    {
        transform.RotateAround(center.transform.position, Vector3.up, rychlost * Time.deltaTime);
        transform.RotateAround(center.transform.position, Vector3.right, rychlost * Time.deltaTime/10);
    }
}
