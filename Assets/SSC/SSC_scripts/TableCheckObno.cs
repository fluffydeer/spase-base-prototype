using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableCheckObno : MonoBehaviour {

    public GameObject podstavec;

    public GameObject svetlozle;
    public GameObject svetlodobre;

    private void Update()
    {
        if(podstavec.tag == "Placed")
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
        if (coll.collider.name == "Hornadoska")
        {
            podstavec.tag = "Placed";
           
        }
       /* else
        {
            podstavec.tag = "Untagged";
        }*/
    }

    private void OnCollisionExit(Collision coll)
    {
        if (coll.collider.name == "Hornadoska")
        {
            podstavec.tag = "Untagged";
           
        }
       /* else
        {
            podstavec.tag = "Untagged";
        }*/
    }
}
