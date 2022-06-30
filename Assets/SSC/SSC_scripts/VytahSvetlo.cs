using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VytahSvetlo : MonoBehaviour {

    public GameObject vytah;
    public Material Zelene;
    public Material Oranzove;
    public Material Cervene;
    public GameObject tlacitko1;
    public GameObject tlacitko2;
    public GameObject tlacitko3;
    public GameObject tlacitko4;

    public Text textik;

    public float krok;

    public AudioSource zvuk;
    private float hodnota = 0;
    private float kontrola = 0;
    private float uzbolohore = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(vytah.transform.position.y < 0.15)
        {
            tlacitko1.GetComponent<MeshRenderer>().material = Cervene;
            tlacitko2.GetComponent<MeshRenderer>().material = Cervene;
            tlacitko3.GetComponent<MeshRenderer>().material = Cervene;
            tlacitko4.GetComponent<MeshRenderer>().material = Cervene;
            zvuk.enabled = false;
            hodnota = 0;
        }
        else if(vytah.transform.position.y >= 10)
        {
            tlacitko1.GetComponent<MeshRenderer>().material = Zelene;
            tlacitko2.GetComponent<MeshRenderer>().material = Zelene;
            tlacitko3.GetComponent<MeshRenderer>().material = Zelene;
            tlacitko4.GetComponent<MeshRenderer>().material = Zelene;
            zvuk.enabled = false;
            hodnota = 1;
        }
        else
        {
            tlacitko1.GetComponent<MeshRenderer>().material = Oranzove;
            tlacitko2.GetComponent<MeshRenderer>().material = Oranzove;
            tlacitko3.GetComponent<MeshRenderer>().material = Oranzove;
            tlacitko4.GetComponent<MeshRenderer>().material = Oranzove;
            zvuk.enabled = true;
            hodnota = 2;
        }

        if(hodnota == 1)
        {
            if(kontrola < 20)
            {
                textik.text = Mathf.Round(kontrola)  + ".00 V";
                kontrola += krok;
            }
            else
            {
                kontrola = 20;
                uzbolohore = 1;
            }
        }

        if(hodnota == 2 && uzbolohore == 1)
        {
            if(kontrola > 0)
            {
                textik.text = Mathf.Round(kontrola) + ".00 V";
                kontrola -= krok;
            }
            else
            {
                textik.text ="00.00 V";
                kontrola = 0;
                uzbolohore = 0;
                hodnota = 0;
            }
            

        }
		
	}

   
}
