using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpace : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.right * Time.deltaTime * 0,5);
        transform.Rotate(Vector3.up * Time.deltaTime * 0,2);
    }
}
