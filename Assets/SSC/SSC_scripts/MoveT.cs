using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveT : MonoBehaviour {

   

    public GameObject objekt;
    public bool x;
    public float xpoziciaZaciatok;
    public float xpoziciaCiel;
    public float XKrok;

    public bool y;
    public float ypoziciaZaciatok;
    public float ypoziciaCiel;
    public float YKrok;

    public bool z;
    public float zpoziciaZaciatok;
    public float zpoziciaCiel;
    public float ZKrok;

    private float smer = 0;

    private void Update()
    {
        if (smer == 1) {
            if (x == true)
            {
                objekt.transform.position = Vector3.MoveTowards(objekt.transform.position, new Vector3(xpoziciaZaciatok + xpoziciaCiel, objekt.transform.position.y, objekt.transform.position.z), XKrok);
            }

            if (y == true)
            {
                objekt.transform.position = Vector3.MoveTowards(objekt.transform.position, new Vector3(objekt.transform.position.x, ypoziciaZaciatok + ypoziciaCiel, objekt.transform.position.z), YKrok);
            }

            if (z == true)
            {
                objekt.transform.position = Vector3.MoveTowards(objekt.transform.position, new Vector3(objekt.transform.position.x, objekt.transform.position.y, zpoziciaZaciatok + zpoziciaCiel), ZKrok);
            }

            if(objekt.transform.position.y == 10)
            {
                objekt.tag = "Placed";
                smer = 0;
            }
        }

        if (smer == 2)
        {
            if (x == true)
            {
                objekt.transform.position = Vector3.MoveTowards(objekt.transform.position, new Vector3(xpoziciaZaciatok + xpoziciaCiel, objekt.transform.position.y, objekt.transform.position.z), XKrok);
            }

            if (y == true)
            {
                objekt.transform.position = Vector3.MoveTowards(objekt.transform.position, new Vector3(objekt.transform.position.x, 0, objekt.transform.position.z), YKrok);
            }

            if (z == true)
            {
                objekt.transform.position = Vector3.MoveTowards(objekt.transform.position, new Vector3(objekt.transform.position.x, objekt.transform.position.y, zpoziciaZaciatok + zpoziciaCiel), ZKrok);
            }

            if (objekt.transform.position.y == 0)
            {
               
                smer = 0;
            }
        }
    }

    public void posunutiehore()
    {
        smer = 1;
    }

    public void posunutiedole()
    {
        objekt.tag = "Untagged";
        smer = 2;
    }
}
