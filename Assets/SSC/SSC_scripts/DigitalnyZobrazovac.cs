using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitalnyZobrazovac : MonoBehaviour {

    public Slider posuvnikosvetlenie;
    public Slider posuvnikzataz;

    public Text digital;

    private float osvetleniehodnota;
    private float zatazhodnota;
    private int tmp;

    public void osvetlenie()
    {
        if(posuvnikosvetlenie.value == 0)
        {
            digital.text = "Off";
        }
        else
        {
            digital.text = (posuvnikosvetlenie.value*100) + " lux";
        }
    }

    public void zataz()
    {
        if (posuvnikzataz.value == 0)
        {
            digital.text = "Off";
        }
        else if(posuvnikzataz.value == 1)
        {
            digital.text = "Z < R";
        }
        else if (posuvnikzataz.value == 2)
        {
            digital.text = "Z = R";
        }
        else 
        {
            digital.text = "Z > R";
        }
    }

    public void voltmeter()
    {
        if (posuvnikosvetlenie.value == 0 || posuvnikzataz.value == 0)
        {
            digital.text = "Off";
        }
        else
        {
            osvetleniehodnota = posuvnikosvetlenie.value/5;
            zatazhodnota = posuvnikzataz.value;
            if(zatazhodnota == 1)
            {
                tmp = -1;
            }
            else if(zatazhodnota == 2)
            {
                tmp = 0;
            }
            else
            {
                tmp = 1;
            }

            digital.text = (osvetleniehodnota + tmp) + " V";

        }
    }

}
