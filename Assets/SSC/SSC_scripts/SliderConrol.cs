using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderConrol : MonoBehaviour {

    public Slider posuvnik;

	public void pridat()
    {
        posuvnik.value += 1;
    }
    public void ubrat()
    {
        posuvnik.value -= 1;
    }
}
