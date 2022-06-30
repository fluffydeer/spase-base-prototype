using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkrinaRuci : MonoBehaviour {

    public float cas;
    public GameObject rucicka;
    public float uhol;

    private float time;
    private float zacuhol;
    private float menic = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if(time > cas)
        {
            if (menic == 1)
            {
                for(zacuhol = 0; zacuhol < uhol; zacuhol++)
                {
                    rucicka.transform.Rotate(Vector3.up);
                }
                menic = 2;
            }
            else
            {
                for (zacuhol = 0; zacuhol < uhol; zacuhol++)
                {
                    rucicka.transform.Rotate(Vector3.up*(-1));
                }
                menic = 1;
            }

            time = 0f;
        }
		
	}
}
