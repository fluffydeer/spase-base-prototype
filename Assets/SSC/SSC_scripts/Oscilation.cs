using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilation : MonoBehaviour {

    public GameObject rucicka;
    public float cas;
    public float rychlost;
    private float time;
    private int prepinac = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if(time > cas)
        {
            if(prepinac == -1)
            {
                prepinac = 1;
            }
            else
            {
                prepinac = -1;
            }
            time = 0f;
        }

        rucicka.transform.Rotate(Vector3.right * rychlost * prepinac);


	}
}
