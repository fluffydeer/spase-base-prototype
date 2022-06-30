using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour {

    public GameObject baterka;
    public GameObject nabijanie;

    public GameObject nabijacka1;
    public GameObject nabijacka2;

    public GameObject cc1;
    public GameObject cc2;

    public GameObject voltmeter1;
    public GameObject voltmeter2;

    public GameObject solar1;
    public GameObject solar2;

    private void Update()
    {
        if((solar1.tag == "Placed" || solar2.tag == "Placed") && (voltmeter1.tag == "Placed" || voltmeter2.tag == "Placed") && (cc1.tag == "Placed" || cc2.tag == "Placed") && (nabijacka1.tag == "Placed" || nabijacka2.tag == "Placed") ) {
            nabijanie.tag = "Placed";
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Podstavec_Baterka")
        {
            baterka.tag = "Placed";
        }
        else
        {
            baterka.tag = "Untagged";
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.name == "Podstavec_Baterka")
        {
            baterka.tag = "Placed";
        }
        else
        {
            baterka.tag = "Untagged";
        }
    }
}
