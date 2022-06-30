using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour {

    public Light indicatorLight;

    public string sceneName;

    private bool isBeingHeld = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void planetIsGrabed() {
        // turn the light on
        this.indicatorLight.enabled = true;

        this.isBeingHeld = true;
    }


    public void planetIsReleased() {
        // turn the light off
        this.indicatorLight.enabled = false;

        this.isBeingHeld = false;
    }

    public bool isHeld() {
        return this.isBeingHeld;
    }

}
