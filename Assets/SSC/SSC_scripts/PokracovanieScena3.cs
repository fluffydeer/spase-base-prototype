using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PokracovanieScena3 : MonoBehaviour {

    public Slider osvetlenie;
    public Slider zataz;
    public GameObject platno;
    public GameObject teleporter;
    

    private float cas = 0;
    private int zostavam = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(osvetlenie.value == 20 && zataz.value == 2 && zostavam == 1)
        {
            cas += 1;
            if(cas > 50)
            {
                platno.SetActive(true);
                teleporter.SetActive(true);
            }
        }
        else
        {
            cas = 0;
        }
	}

    public void pokracovat(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void zostat()
    {
        platno.SetActive(false);
        zostavam = 0;
    }
}
