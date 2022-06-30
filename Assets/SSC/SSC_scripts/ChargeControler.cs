using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeControler : MonoBehaviour {

    public GameObject objekt;

    public GameObject solar1;
    public GameObject solar2;

    public GameObject tlacitko1;
    public GameObject tlacitko2;
    public GameObject tlacitko3;

    public Material cervene;
    public Material zelene;

    public Text textik;

    public GameObject voltmeter1;
    public GameObject voltmeter2;
	
	// Update is called once per frame
	void Update () {

        if(objekt.tag == "Placed" && (voltmeter1.tag == "Placed" || voltmeter2.tag == "Placed"))
        {
            tlacitko1.GetComponent<MeshRenderer>().material = zelene;
            tlacitko2.GetComponent<MeshRenderer>().material = zelene;
            tlacitko3.GetComponent<MeshRenderer>().material = zelene;

            if(solar1.tag == "Placed" || solar2.tag == "Placed")
            {
                textik.text = "On";
            }

        }
        else
        {
            tlacitko1.GetComponent<MeshRenderer>().material = cervene;
            tlacitko2.GetComponent<MeshRenderer>().material = cervene;
            tlacitko3.GetComponent<MeshRenderer>().material = cervene;

            textik.text = "Off";
        }
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Podstavec_CC")
        {
            objekt.tag = "Placed";
        }
        else
        {
            objekt.tag = "Untagged";
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.collider.name == "Podstavec_CC")
        {
            objekt.tag = "Placed";
        }
        else
        {
            objekt.tag = "Untagged";
        }
    }
}
