using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnapDropPlanet : MonoBehaviour {

    public GameObject higlighter;

    private Planet planetInRange;

	// Use this for initialization
	void Start () {
        planetInRange = null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void checkPlanetDrop() {
        if(this.planetInRange != null) {
            this.dropPlanet(this.planetInRange);
        }
    }

    private void dropPlanet(Planet p) {
        // disable orbit if this orbits sun
        OrbitSun osPlanet = p.GetComponent("OrbitSun") as OrbitSun;
        if (osPlanet != null)
        {
            osPlanet.stopOrbit();
        }

        // set the planets position
        Rigidbody rb = p.GetComponent<Rigidbody>();

        rb.position = this.transform.position;
        rb.velocity = Vector3.zero;

        // hide the highlighter
        this.higlighter.SetActive(false);

        // load the required scene
        SceneManager.LoadSceneAsync(p.sceneName);
    }

    // object enters the sphere collider
    private void OnTriggerEnter(Collider collider) {
        // show the highlighter
        if (collider.gameObject.CompareTag("Planet")) {

            Planet p = collider.gameObject.GetComponent("Planet") as Planet;

            // is the planet held at the moment?
            if (p.isHeld()) {
                this.higlighter.SetActive(true);

                this.planetInRange = p;
            }
        }
    }

    // object leaves the sphere collider
    private void OnTriggerExit(Collider collider) {
        // hide the highlighter
        if (collider.gameObject.CompareTag("Planet")) {

            Planet p = collider.gameObject.GetComponent("Planet") as Planet;

            // is the planet held at the moment?
            if (p.isHeld()) {
                this.higlighter.SetActive(false);

                this.planetInRange = null;
            }
        }
    }
}
