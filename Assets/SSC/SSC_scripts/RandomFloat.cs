using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomFloat : MonoBehaviour {

    public float cas;
    public Text textik;
    private float time;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if(time > cas)
        {
            textik.text = Mathf.Round(Random.Range(0.0f,9999.9f)) + "." + Mathf.Round(Random.Range(10.0f,99.9f));
            time = 0f;
        }
		
	}
}
