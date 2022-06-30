using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableCheckNeobnoV2 : MonoBehaviour {

    public GameObject podstavec;
    public GameObject svetlozle;
    public GameObject svetlodobre;

    public GameObject stolik;


    private void Update()
    {
        if (podstavec.tag == "Placed")
        {
            svetlozle.SetActive(false);
            svetlodobre.SetActive(true);
        }
        else
        {
            svetlozle.SetActive(true);
            svetlodobre.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision coll)
    {
        print(coll.collider);
        if (coll.collider.name == "Hornadoska1")
        {
            podstavec.tag = "Placed";
        }
        else
        {
            podstavec.tag = "Untagged";
        }
    }

    private void OnCollisionExit(Collision coll)
    {
        if (coll.collider.name == "Hornadoska1")
        {
            podstavec.tag = "Placed";
        }
        else
        {
            podstavec.tag = "Untagged";
        }
    }
}
