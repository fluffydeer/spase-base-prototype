using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class FloatingObject : MonoBehaviour {

    public float levitationforce;
    public float levitationposition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < levitationposition)
        {
            transform.GetComponent<Rigidbody>().AddForce(Vector3.up * levitationforce);
        }

        if(transform.position.y >= levitationposition)
        {
            transform.GetComponent<Rigidbody>().AddForce(Vector3.up);
        }
	}
}
