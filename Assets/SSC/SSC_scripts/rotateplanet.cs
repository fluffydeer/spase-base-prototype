﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateplanet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        // transform.Rotate(new Vector3(0, Time.deltaTime, Time.deltaTime * (-2)));
        transform.Rotate(Vector3.right * Time.deltaTime*2);
        //transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
        // transform.Rotate(0, Time.deltaTime, 0, Space.World);
       // transform.Rotate(Vector3.up, Time.deltaTime, Space.World);
    }
}
