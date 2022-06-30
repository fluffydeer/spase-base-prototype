using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OsvetleniePosuvac : MonoBehaviour {

    public Light svetlo;
    public Slider posuvac;

    public void zmenaosvetlenia()
    {
        svetlo.intensity = posuvac.value / 2;
    }
    
}
