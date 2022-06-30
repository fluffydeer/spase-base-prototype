using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiting : MonoBehaviour {
    public GameObject center;

    public bool Hore;
    public float RychlostHore;

    public bool Vpravo;
    public float RychlostVpravo;

    public bool Vpredu;
    public float RychlostVpredu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        OrbitingAround();
    }

    void OrbitingAround()
    {
        if(Hore == true)
        {
            transform.RotateAround(center.transform.position, Vector3.up, RychlostHore * Time.deltaTime);
        }

        if (Vpravo == true)
        {
            transform.RotateAround(center.transform.position, Vector3.right, RychlostVpravo * Time.deltaTime);
        }

        if (Vpredu == true)
        {
            transform.RotateAround(center.transform.position, Vector3.forward, RychlostVpredu * Time.deltaTime);
        }
    }
}
