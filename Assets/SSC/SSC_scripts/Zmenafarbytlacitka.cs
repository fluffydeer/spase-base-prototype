using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zmenafarbytlacitka : MonoBehaviour {


    public GameObject tlacitko;
    public float cas;

    public Material cervene;
    public Material zelene;
    public Material oranzove;

    private float time;
    private Material materialik;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;

        if(time > cas)
        {
            materialik = tlacitko.GetComponent<MeshRenderer>().material;
            if (materialik.name == "Tlacitko_cervene (Instance)") 
            {
                tlacitko.GetComponent<MeshRenderer>().material = zelene;
            }
            else if (materialik.name == "TlacitkoOranzove (Instance)") 
            {
                tlacitko.GetComponent<MeshRenderer>().material = cervene;
            }
            else
            {
                tlacitko.GetComponent<MeshRenderer>().material = oranzove;
            }

            time = 0f;
         
        }
		
	}
}
