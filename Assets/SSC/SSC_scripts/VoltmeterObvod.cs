using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoltmeterObvod : MonoBehaviour {

    public GameObject objekt;
    public GameObject solar1;
    public GameObject solar2;
    public Text textik;

    public GameObject tlacitko1;
    public GameObject tlacitko2;

    public Material cervene;
    public Material zelene;

    private float kontrola = 0;
    private float zapojene = 0;

    void Update()
    {



           if(objekt.tag == "Placed")
        {
            if (solar1.tag == "Placed" || solar2.tag == "Placed")
            {
                tlacitko1.GetComponent<MeshRenderer>().material = zelene;
                tlacitko2.GetComponent<MeshRenderer>().material = zelene;

                if(kontrola < 40)
                {
                    textik.text = Mathf.Round(kontrola) + ".00 V";
                    kontrola += 0.2f;
                }
                else if(kontrola > 40 && zapojene == 0)
                {
                    textik.text = Mathf.Round(kontrola) + ".00 V";
                    kontrola -= 0.2f;
                }
                //textik.text = "40.00 V";
            }
            if (solar1.tag == "Placed" && solar2.tag == "Placed")
            {

                if (kontrola < 80)
                {
                    textik.text = Mathf.Round(kontrola) + ".00 V";
                    kontrola += 0.2f;
                }
                zapojene = 1;
                //textik.text = "80.00 V";
            }
            else
            {
                zapojene = 0;
            }

            if(solar1.tag == "Untagged" && solar2.tag == "Untagged")
            {
                if(kontrola > 0)
                {
                    textik.text = Mathf.Round(kontrola) + ".00 V";
                    kontrola -= 0.2f;
                }
                else
                {
                    textik.text =" ";
                    tlacitko1.GetComponent<MeshRenderer>().material = cervene;
                    tlacitko2.GetComponent<MeshRenderer>().material = cervene;
                    kontrola = 0;
                }


            }
        }
        else
        {
            tlacitko1.GetComponent<MeshRenderer>().material = cervene;
            tlacitko2.GetComponent<MeshRenderer>().material = cervene;
            textik.text = "";
            kontrola = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "Podstavec_voltmeter")
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
        if (collision.collider.name == "Podstavec_voltmeter")
        {
            objekt.tag = "Placed";
            
        }
        else
        {
            objekt.tag = "Untagged";
        }
    }
}
