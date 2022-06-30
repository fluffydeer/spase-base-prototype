using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nabijacka : MonoBehaviour {

    public GameObject objekt;
    public GameObject bateria1;
    public GameObject bateria2;

    public GameObject solar1;
    public GameObject solar2;

    public Text textik;

    public GameObject voltmeter1;
    public GameObject voltmeter2;

    public GameObject cc1;
    public GameObject cc2;

    private void Update()
    {
            if ((solar1.tag == "Placed" || solar2.tag == "Placed") && (voltmeter1.tag == "Placed" || voltmeter2.tag == "Placed") && (cc1.tag == "Placed" || cc2.tag == "Placed"))
            {
                if (bateria1.tag == "Placed" || bateria2.tag == "Placed")
                {
                    textik.text = "Prebieha nabíjanie";
                }
                else
                {
                    textik.text = "Batéria nepripojená";
                }
            }
        else
        {
            textik.text = "";
        }

            if(objekt.tag == "Untagged")
        {
            textik.text = " ";
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Podstavec_Nabijacka")
        {
            objekt.tag = "Placed";
        }
        else
        {
            objekt.tag = "Untagged";
           
        }
    }
}
