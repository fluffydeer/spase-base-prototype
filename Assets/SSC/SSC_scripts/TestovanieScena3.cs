using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestovanieScena3 : MonoBehaviour {

    public Slider Osvetlenie;
    public Slider zataz;

    public GameObject pokracovanie;
    public GameObject zlakonf;
    public GameObject teleporterik;

    public GameObject tlacitko1;
    public GameObject tlacitko2;
    public GameObject platno;

    private int stlacene = 0;


	public void kontrola()
    {
        if(Osvetlenie.value == 20 && zataz.value == 2)
        {
            pokracovanie.SetActive(true);
            teleporterik.SetActive(true);
        }
        else
        {
            zlakonf.SetActive(true);
        }
    }

    public void zlakonfiguracia()
    {
        zlakonf.SetActive(false);
    }

    public void zostavam()
    {
        pokracovanie.SetActive(false);
    }

    public void pokracovaniedalej(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void stlacenietlacitka()
    {
        if (stlacene == 0)
        {
            tlacitko1.transform.position = Vector3.MoveTowards(tlacitko1.transform.position, new Vector3(tlacitko1.transform.position.x + 0.05f, tlacitko1.transform.position.y, tlacitko1.transform.position.z), 1);
            tlacitko2.transform.position = Vector3.MoveTowards(tlacitko2.transform.position, new Vector3(tlacitko2.transform.position.x + 0.05f, tlacitko2.transform.position.y, tlacitko2.transform.position.z), 1);
            platno.transform.position = Vector3.MoveTowards(platno.transform.position, new Vector3(platno.transform.position.x + 0.05f, platno.transform.position.y, platno.transform.position.z), 1);
            stlacene = 1;
        }
    }

    public void odtlacenietlacitka()
    {
        if (stlacene == 1)
        {
            tlacitko1.transform.position = Vector3.MoveTowards(tlacitko1.transform.position, new Vector3(tlacitko1.transform.position.x - 0.05f, tlacitko1.transform.position.y, tlacitko1.transform.position.z), 1);
            tlacitko2.transform.position = Vector3.MoveTowards(tlacitko2.transform.position, new Vector3(tlacitko2.transform.position.x - 0.05f, tlacitko2.transform.position.y, tlacitko2.transform.position.z ), 1);
            platno.transform.position = Vector3.MoveTowards(platno.transform.position, new Vector3(platno.transform.position.x - 0.05f, platno.transform.position.y, platno.transform.position.z ), 1);
            stlacene = 0;
        }
    }
}
