using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnergyCheck1 : MonoBehaviour {

    public GameObject ZemnyPlyn;
    public GameObject Ropa;
    public GameObject Uhlie;
    public GameObject Voda;
    public GameObject Vietor;
    public GameObject Slnko;
    public GameObject Geot;
    public GameObject Nuklear;

    public GameObject platno;

    public GameObject teleporterik;

    private float stlacene = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(ZemnyPlyn.tag == "Placed" && Ropa.tag == "Placed" && Uhlie.tag == "Placed" && Voda.tag == "Placed" && Vietor.tag == "Placed" && Slnko.tag == "Placed" && Geot.tag == "Placed" && Nuklear.tag == "Placed" && stlacene == 0) {

            platno.SetActive(true);
            teleporterik.SetActive(true);
        }
		
	}

    public void zostat()
    {
        platno.SetActive(value: false);
        stlacene = 1;
        
    }

    public void odist(int Index)
    {
        SceneManager.LoadScene(Index);
    }
}
