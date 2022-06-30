using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PokracovanieScena : MonoBehaviour {

    public GameObject spotrebic;
    public GameObject platno;
    public GameObject teleporter;

    private int zostavam = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(spotrebic.tag == "Placed" && zostavam == 1)
        {
            platno.SetActive(true);
            teleporter.SetActive(true);
        }

	}

    public void zostavamtu()
    {
        platno.SetActive(false);
        zostavam = 0;
    }

    public void pokracujem(int index)
    {
        SceneManager.LoadScene(index);
    }
}
