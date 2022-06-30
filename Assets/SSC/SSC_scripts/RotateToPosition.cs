using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToPosition : MonoBehaviour {



     public GameObject Tocna;
     //public float cas;
     public float rychlost;

    public float uhol1;
    public float uhol2;
     private float zaciatok = 1;

     public GameObject plosina;

     private float time = 0;

     void Update()
     {
       /*  time += Time.deltaTime;
         if(time < cas)
         {
             Tocna.transform.Rotate(Vector3.forward * rychlost * (zaciatok));
         }*/

             if(zaciatok == 1)
             {
                 plosina.transform.position = Vector3.MoveTowards(plosina.transform.position, new Vector3(plosina.transform.position.x, 1.728908e-16f + 10, plosina.transform.position.z),0.01f);
                   /*var rotacia = Tocna.transform.rotation.z;
                        if(rotacia != uhol1)
                        {
                            Tocna.transform.Rotate(Vector3.forward * rychlost * (zaciatok));
                        }
            print(rotacia);*/
             }

             if (zaciatok == -1)
             {
                 plosina.transform.position = Vector3.MoveTowards(plosina.transform.position, new Vector3(plosina.transform.position.x, 1.728908e-16f, plosina.transform.position.z), 0.01f);
                 /*   var rotacia = Tocna.transform.rotation.z;
                    if (rotacia != uhol2)
                    {
                        Tocna.transform.Rotate(Vector3.forward * rychlost * (zaciatok));
                    }*/
        }

         if (plosina.transform.position.y == 1.728908e-16f + 10)
             {
             plosina.tag = "Placed";
 
             }

     }

    

    public void hore()
    {
        zaciatok = 1;
        time = 0;
    }

    public void dole()
    {
        zaciatok = -1;
        time = 0;
        plosina.tag = "Untagged";
    }
}
