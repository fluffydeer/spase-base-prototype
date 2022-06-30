using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZmenaObrazovky1 : MonoBehaviour {

    public Slider posuvnik;
    public Image MensieR;
    public Image RovneR;
    public Image VacsieR;

	public void zmenaobrazu()
    {
        if(posuvnik.value == 0)
        {
            MensieR.enabled = !enabled;
            RovneR.enabled = !enabled;
            VacsieR.enabled = !enabled;
        }
        else if(posuvnik.value == 1)
        {
            MensieR.enabled = enabled;
            RovneR.enabled = !enabled;
            VacsieR.enabled = !enabled;
        }
        else if (posuvnik.value == 2)
        {
            MensieR.enabled = !enabled;
            RovneR.enabled = enabled;
            VacsieR.enabled = !enabled;
        }
        else
        {
            MensieR.enabled = !enabled;
            RovneR.enabled = !enabled;
            VacsieR.enabled = enabled;
        }
    }
}
