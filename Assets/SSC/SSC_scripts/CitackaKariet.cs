using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CitackaKariet : MonoBehaviour {

    public GameObject Karta;

    public GameObject Load1;
    public GameObject Load2;
    public GameObject Load3;
    public GameObject Load4;
    public GameObject Load5;
    public GameObject Load6;
    public GameObject Load7;
    public GameObject Load8;
    public GameObject Load9;
    public GameObject Load10;
    public GameObject Load11;
    public GameObject Load12;
    public GameObject Load13;
    public GameObject Load14;

    public Light SvetloOk;
    public Light SvetloZle;

    public int SceneIndex;

    //public AudioSource Vytah;
    public AudioSource Cink;
    public AudioSource ZLECINK;
    public int maxRange;

    public Material LoadingMaterial;
    public Material OldMaterial;

    public bool Testing = false;
    private float MyTime = 0;
    private float MyTime2 = 0;
    private bool zlecink = false;

    private bool Zlypokus = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*if (Vector3.Distance(transform.position, Karta.transform.position) < maxRange)
        {
            DalsiaScena();
        }*/
        if(Testing == true)
        {
            if(Karta.tag == "CanContinue")
            {
                DalsiaScena();
            }
            else
            {
                if(Zlypokus == true)
                {
                    NedovolenyPokus();
                }  
            }
            MyTime += Time.deltaTime;
        }
        else
        {
            Zlypokus = true;
            ZleNacitanie();
            MyTime2 += Time.deltaTime;
        }
        
    }

    private void ZleNacitanie()
    {
        if (zlecink == true)
        {
            MyTime = 0;
            Load1.GetComponent<MeshRenderer>().material = OldMaterial;
            Load2.GetComponent<MeshRenderer>().material = OldMaterial;
            Load3.GetComponent<MeshRenderer>().material = OldMaterial;
            Load4.GetComponent<MeshRenderer>().material = OldMaterial;
            Load5.GetComponent<MeshRenderer>().material = OldMaterial;
            Load6.GetComponent<MeshRenderer>().material = OldMaterial;
            Load7.GetComponent<MeshRenderer>().material = OldMaterial;
            Load8.GetComponent<MeshRenderer>().material = OldMaterial;
            Load9.GetComponent<MeshRenderer>().material = OldMaterial;
            Load10.GetComponent<MeshRenderer>().material = OldMaterial;
            Load11.GetComponent<MeshRenderer>().material = OldMaterial;
            Load12.GetComponent<MeshRenderer>().material = OldMaterial;
            Load13.GetComponent<MeshRenderer>().material = OldMaterial;
            Load14.GetComponent<MeshRenderer>().material = OldMaterial;

            SvetloOk.intensity = 0;
            SvetloZle.intensity = 10;
            ZLECINK.Play();
            MyTime2 = 0;
        }
        else
        {
            if (MyTime2 > 2)
            {
                SvetloZle.intensity = 0;
            }
        }
        zlecink = false;
    }

    private void DalsiaScena()
    {
        SvetloZle.intensity = 0;
        zlecink = true;
        //print("ASPON MA TO ZAVOLALO");
     
            if(MyTime > 0)
            {
                Load1.GetComponent<MeshRenderer>().material = LoadingMaterial;
                Load2.GetComponent<MeshRenderer>().material = LoadingMaterial;
            }
            if (MyTime > 0.1)
            {
                Load3.GetComponent<MeshRenderer>().material = LoadingMaterial;
                Load4.GetComponent<MeshRenderer>().material = LoadingMaterial;
            }
            if (MyTime > 0.2)
            {
                Load5.GetComponent<MeshRenderer>().material = LoadingMaterial;
                Load6.GetComponent<MeshRenderer>().material = LoadingMaterial;
            }
            if (MyTime > 0.3)
            {
                Load7.GetComponent<MeshRenderer>().material = LoadingMaterial;
                Load8.GetComponent<MeshRenderer>().material = LoadingMaterial;
            }
            if (MyTime > 0.4)
            {
                Load9.GetComponent<MeshRenderer>().material = LoadingMaterial;
                Load10.GetComponent<MeshRenderer>().material = LoadingMaterial;
            }
            if (MyTime > 0.45)
            {
                Load11.GetComponent<MeshRenderer>().material = LoadingMaterial;
                Load12.GetComponent<MeshRenderer>().material = LoadingMaterial;
            }
            if (MyTime > 0.5)
            {
                Load13.GetComponent<MeshRenderer>().material = LoadingMaterial;
                Load14.GetComponent<MeshRenderer>().material = LoadingMaterial;
            }
            if(MyTime > 0.6)
            {
                SvetloOk.intensity = 10;
                Cink.Play();
            }
            if(MyTime > 0.7)
            {
                Cink.Pause();
                //Vytah.Play();
            }
            if(MyTime > 0.8)
            {
            SceneManager.LoadScene(SceneIndex);
        }

        
    }

    private void NedovolenyPokus()
    {
        SvetloOk.intensity = 0;
        //print("ASPON MA TO ZAVOLALO");
        zlecink = true;
        print(MyTime);

        if (MyTime > 0)
        {
            Load1.GetComponent<MeshRenderer>().material = LoadingMaterial;
            Load2.GetComponent<MeshRenderer>().material = LoadingMaterial;
        }
        if (MyTime > 0.1)
        {
            Load3.GetComponent<MeshRenderer>().material = LoadingMaterial;
            Load4.GetComponent<MeshRenderer>().material = LoadingMaterial;
        }
        if (MyTime > 0.2)
        {
            Load5.GetComponent<MeshRenderer>().material = LoadingMaterial;
            Load6.GetComponent<MeshRenderer>().material = LoadingMaterial;
        }
        if (MyTime > 0.3)
        {
            Load7.GetComponent<MeshRenderer>().material = LoadingMaterial;
            Load8.GetComponent<MeshRenderer>().material = LoadingMaterial;
        }
        if (MyTime > 0.4)
        {
            Load9.GetComponent<MeshRenderer>().material = LoadingMaterial;
            Load10.GetComponent<MeshRenderer>().material = LoadingMaterial;
        }
        if (MyTime > 0.45)
        {
            Load11.GetComponent<MeshRenderer>().material = LoadingMaterial;
            Load12.GetComponent<MeshRenderer>().material = LoadingMaterial;
        }
        if (MyTime > 0.5)
        {
            Load13.GetComponent<MeshRenderer>().material = LoadingMaterial;
            Load14.GetComponent<MeshRenderer>().material = LoadingMaterial;
        }
        if (MyTime > 0.6)
        {
            SvetloZle.intensity = 10;
            ZLECINK.Play();
        }
        if (MyTime > 0.7)
        {
            ZLECINK.Pause();
            Zlypokus = false;
        }
        if (MyTime > 0.8)
        {
            zlecink = false;
        }
    }
}
