using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inverter : MonoBehaviour {

    public GameObject solar1;
    public GameObject solar2;

    public GameObject rucicka1;
    public GameObject rucicka2;
    public GameObject rucicka3;
    public GameObject rucicka4;

    public GameObject objekt;

    public GameObject tocitko1;
    public GameObject tocitko2;

    public GameObject tlacitko1;
    public GameObject tlacitko2;


    public Material cervene;
    public Material zelene;

    public float rucickacyklus;
    public float tocitkocyklus;

    public GameObject voltmeter1;
    public GameObject voltmeter2;

    public GameObject cc1;
    public GameObject cc2;

    public GameObject nabijacka1;
    public GameObject nabijacka2;

    public GameObject nabijanie1;
    public GameObject nabijanie2;


    private float rucickac = 0;
    private float tocitkoc = 0;

    private float umiestnene = 0;
    private float boloumiestnene = 0;

    private float rucickakrok = 0;
    private float rucickapohyb = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //rucicka1.transform.Rotate(Vector3.up * 100);
        if ((voltmeter1.tag == "Placed" || voltmeter2.tag == "Placed") && (cc1.tag == "Placed" || cc2.tag == "Placed") && (nabijacka1.tag == "Placed" || nabijacka2.tag == "Placed") && ((solar1.tag == "Placed" || solar2.tag == "Placed") || (nabijanie1.tag == "Placed" || nabijanie2.tag == "Placed")))
        {
            if (objekt.tag == "Placed")
            {
               /* if (rucickac < rucickacyklus && rucickapohyb == 1)
                {
                    rucicka1.transform.Rotate(Vector3.right * 0.5f);
                    rucicka2.transform.Rotate(Vector3.right * 0.5f);
                    rucicka3.transform.Rotate(Vector3.right * 0.5f);
                    rucicka4.transform.Rotate(Vector3.right * 0.5f);
                    rucickac += 1;
                }
                else
                {
                    rucickapohyb = 0;
                    rucickac = rucickacyklus;
                    boloumiestnene = 1;
                    umiestnene = 0;
                }

                if (tocitkoc < tocitkocyklus && rucickapohyb == 1)
                {
                    tocitko1.transform.Rotate(Vector3.forward * (-1));
                    tocitko2.transform.Rotate(Vector3.forward * (-1));
                    tocitkoc += 1;
                }
                else
                {
                    tocitkoc = tocitkocyklus;
                }*/

                tlacitko1.GetComponent<MeshRenderer>().material = zelene;
                tlacitko2.GetComponent<MeshRenderer>().material = zelene;
            }

            if (boloumiestnene == 1 && objekt.tag == "Untagged")
            {
              /*  if (rucickac > 0 && rucickapohyb == 1)
                {
                    rucicka1.transform.Rotate(Vector3.right * (-0.5f));
                    rucicka2.transform.Rotate(Vector3.right * (-0.5f));
                    rucicka3.transform.Rotate(Vector3.right * (-0.5f));
                    rucicka4.transform.Rotate(Vector3.right * (-0.5f));

                    rucickac -= 1;
                }
                else
                {
                    rucickapohyb = 0;
                    rucickac = 0;
                    boloumiestnene = 0;
                    umiestnene = 0;
                }

                if (tocitkoc > 0 && rucickapohyb == 1)
                {
                    tocitko1.transform.Rotate(Vector3.forward * (1));
                    tocitko2.transform.Rotate(Vector3.forward * (1));
                    tocitkoc -= 1;
                }
                else
                {
                    tocitkoc = 0;
                }*/

                tlacitko1.GetComponent<MeshRenderer>().material = cervene;
                tlacitko2.GetComponent<MeshRenderer>().material = cervene;
            }
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Podstavec_Inverter")
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
        if(collision.collider.name == "Podstavec_Inverter")
        {
            objekt.tag = "Placed";
        }
        else
        {
            objekt.tag = "Untagged";
        }
    }
}
