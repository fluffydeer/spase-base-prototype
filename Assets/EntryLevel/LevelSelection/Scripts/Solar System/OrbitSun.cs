using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitSun : MonoBehaviour {

    public Sun sun;
    public float angularSpeedDeg;
    public float angleOffsetDeg = 0.0f;
    public float maxSpeedMultiplier = 2.0f;
 
    public Vector3 orbitTiltDeg = new Vector3(0.0f, 0.0f, 0.0f);


    private float radius;
    private float orbitAngleRad;
    private float maxSpeed;
    private Rigidbody rb;

    private bool doOrbit = true;

	void Start () {
        // get the radius from the planets initial position
        this.radius = Vector3.Distance(this.sun.transform.position, this.transform.position);
        
        // calculate the initial position on the circular orbit
        this.orbitAngleRad = this.angleOffsetDeg * Mathf.Deg2Rad;

        // calculate the maximal speed
        this.maxSpeed = radius * Mathf.Abs(angularSpeedDeg) * Mathf.Deg2Rad * maxSpeedMultiplier;

        // get the planets rigid body
        this.rb = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (sun != null)
        {
            // increment the orbitAngle
            this.orbitAngleRad += this.angularSpeedDeg * Mathf.Deg2Rad * Time.deltaTime;
            // wrap the angle around
            if (this.orbitAngleRad > 2 * Mathf.PI)
            {
                this.orbitAngleRad -= 2 * Mathf.PI;
            }
            else if (this.orbitAngleRad < -2 * Mathf.PI)
            {
                this.orbitAngleRad += 2 * Mathf.PI;
            }

            // orbit only if you should
            if (this.doOrbit)
            {
                // move the reference point on the orbit
                // position on the orbit in the XZ-plane
                Vector3 orbitPoint = this.calculateOrbitPoint();
                
                // translate the planet in the correct direction
                this.rb.MovePosition(Vector3.MoveTowards(this.transform.position, orbitPoint, this.maxSpeed * Time.deltaTime));

                // check if we are at the orbitPoint
                if(this.rb.transform.position.Equals(orbitPoint)) {
                    // we are at the orbitPoint and we don't need to reset (if one was invoked)
                    CancelInvoke();
                }
            }
        }
    }

    public void stopOrbit() {
        this.doOrbit = false;

        // was caught => cancel all invokes
        CancelInvoke();
    }

    public void continueOrbit() {
        this.doOrbit = true;
        this.transform.rotation = Quaternion.identity;

        // was let go => invoke a reset in 10s
        Invoke("resetPosition", 10);
    }

    public void resetPosition() {
        // set the position of this object to the position of the orbit point
        this.rb.transform.position = this.calculateOrbitPoint();
    }

    private Vector3 calculateOrbitPoint() {
        // position on the orbit in the XZ-plane
        Vector3 orbitPoint = new Vector3(
            this.radius * Mathf.Cos(this.orbitAngleRad),
            0.0f,
            this.radius * Mathf.Sin(this.orbitAngleRad));
        // tilt the orbit according to the given angles
        orbitPoint = Quaternion.Euler(this.orbitTiltDeg.x, this.orbitTiltDeg.y, this.orbitTiltDeg.z) * orbitPoint;
        // tilt the orbit according to the global tilt set inside the Sun
        orbitPoint = this.sun.getGlobalTilt() * orbitPoint; // *operator is only overloaded in this order
        // offset the orbit by the position of the sun
        orbitPoint += this.sun.transform.position;

        return orbitPoint;
    }
}
