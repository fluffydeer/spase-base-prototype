using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour {

    public GameObject zvuk;
    public GameObject spotrebic;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(spotrebic.tag == "Placed")
        {
            zvuk.SetActive(true);
        }
        else
        {
            zvuk.SetActive(false);
        }
	}
}
