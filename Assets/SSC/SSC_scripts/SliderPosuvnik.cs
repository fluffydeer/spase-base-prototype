using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderPosuvnik : MonoBehaviour {

    public Slider posuvnik;
    public GameObject posuvnikdoska;
    public float delenec;
    public float krok;

    public void posuvanie()
    {
        posuvnikdoska.transform.position = Vector3.MoveTowards(transform.position, new Vector3(-0.434896f + (posuvnik.value/delenec), transform.position.y,transform.position.z),krok);
    }
}
