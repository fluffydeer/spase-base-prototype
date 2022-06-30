using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KontrolaUmiestnenia : MonoBehaviour {

    public GameObject Hlavne;
    public Button tlacitko;

    public GameObject o1;
    public GameObject o2;
    public GameObject o3;
    public GameObject o4;
    public GameObject o5;
    public GameObject o6;
    public GameObject o7;

    public Color goodColor;
    public Color badColor;

    void kontrolajedneho()
    {
        if(Hlavne.tag == "Placed")
        {

            tlacitko.tag = "Placed";
            ColorBlock cb = tlacitko.colors;
            cb.normalColor = goodColor;
            tlacitko.colors = cb;
            
        }
        else
        {
            tlacitko.tag = "Untagged";
            ColorBlock cb = tlacitko.colors;
            cb.normalColor = badColor;
            tlacitko.colors = cb;
        }
    }

    void kontrolavsetkych(int sceneIndex)
    {
        //SceneManager.LoadScene(sceneIndex);
    }
}
