using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UvitaciePlatno : MonoBehaviour {

    public GameObject platno;

    public void skrytplatno()
    {
        platno.SetActive(false);
    }
}
