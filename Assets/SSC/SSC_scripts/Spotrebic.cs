using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotrebic : MonoBehaviour {

    // Use this for initialization
    public GameObject spotrebic;

    public GameObject solar1;
    public GameObject solar2;

    public GameObject bateria;
    public GameObject baterka;
    public GameObject nabijacka;
    public GameObject voltmeter;
    public GameObject invertor;
    public GameObject regulator;

    public GameObject bateria2;
    public GameObject baterka2;


    public GameObject nabijacka2;
    public GameObject voltmeter2;
    public GameObject invertor2;
    public GameObject regulator2;

    public GameObject otacanie;

    private float rychlost = 0;

    private float cas1 = 0;
    private float cas2 = 3000;

    // Update is called once per frame
    void Update () {
		
        if(solar1.tag == "Placed" || solar2.tag == "Placed")
        {
            if ((voltmeter.tag == "Placed" || voltmeter2.tag == "Placed") && (invertor.tag == "Placed" || invertor2.tag == "Placed") && (regulator.tag == "Placed" || regulator2.tag == "Placed") && (nabijacka.tag == "Placed" || nabijacka2.tag == "Placed"))
            {
                if (solar1.tag == "Placed" && solar2.tag == "Placed")
                {
                    rychlost = -5;
                    //spotrebic.tag = "Placed";
                }
                else
                {
                    rychlost = -3;
                    //spotrebic.tag = "Placed";
                }
            }
            else
            {
                rychlost = 0;
                //spotrebic.tag = "Untagged";
            }
        }
        else
        {
            if ((baterka.tag == "Placed" || baterka2.tag == "Placed") && (invertor.tag == "Placed" || invertor2.tag == "Placed"))
            {
                rychlost = -3f;
                //spotrebic.tag = "Placed";
                if (cas1 < cas2)
                {
                    cas1 += 1;
                    rychlost -= 0.1f;
                }
                else
                {
                    cas1 = 0;
                    baterka.tag = "Untagged";
                    baterka2.tag = "Untagged";
                }

            }
            else
            {
                rychlost = 0;
                //spotrebic.tag = "Untagged";
            }



        }

        otacanie.transform.Rotate(Vector3.right * rychlost);

        if(rychlost == 0)
        {
            spotrebic.tag = "Untagged";
        }
        else
        {
            spotrebic.tag = "Placed";
        }

	}
}
