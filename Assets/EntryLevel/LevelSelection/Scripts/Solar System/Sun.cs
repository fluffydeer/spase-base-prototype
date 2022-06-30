using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {

    public Vector3 globalOrbitTiltDeg = new Vector3(0.0f, 0.0f, 0.0f);

    private Quaternion globalTiltQuat;

	// Use this for initialization
	void Start () {
        this.globalTiltQuat = Quaternion.Euler(this.globalOrbitTiltDeg.x, this.globalOrbitTiltDeg.y, this.globalOrbitTiltDeg.z);
    }
	
	public Quaternion getGlobalTilt() {
        OrbitSun osThis = this.GetComponent("OrbitSun") as OrbitSun;
        if (osThis != null) {
            return this.globalTiltQuat * osThis.sun.getGlobalTilt(); // combine the global tilt of this and this' sun
        }
        return this.globalTiltQuat;
    }
}
