using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiting_delay : MonoBehaviour {
    public GameObject center;

    public bool Hore;
    public float RychlostHore;

    public bool Vpravo;
    public float RychlostVpravo;

    public bool Vpredu;
    public float RychlostVpredu;

    public bool Delay;
    public int DelayTime;

    public int RotateTime;

    public AudioSource MySound;

    private int MyDelay = 0;
    private int MyRotateTime = 0;

    private Vector3 mySpawnPoint;
    private Quaternion mySpawnRotation;
    private bool playing = false;
    private int tmp = 0;

    // Use this for initialization
    void Start()
    {
        //var mySpawnPoint: Transform;
        //var mySpawnRotation : Quaternion;
        mySpawnPoint = transform.position;
        mySpawnRotation = transform.rotation;
        Debug.Log(mySpawnPoint);
        Debug.Log(mySpawnRotation);
    }

    // Update is called once per frame
    void Update()
    {
        OrbitingAround();
    }

    void OrbitingAround()
    {
        if (Hore == true)
        {
            if(Delay == true)
            {
                MyDelay += 1;
                if (MyDelay > DelayTime)
                {
                    if(MyRotateTime == 0)
                    {
                        MySound.Play(10);
                    }
                    
                    MyRotateTime += 1;
                    transform.RotateAround(center.transform.position, Vector3.up, RychlostHore * Time.deltaTime);
                    if(MyRotateTime == RotateTime)
                    {
                        transform.position = mySpawnPoint;
                        transform.rotation = mySpawnRotation;
                        MyDelay = 0;
                        MyRotateTime = 0;
                        playing = true;
                        tmp = 0;
                    }
                }
            }
            else
            {
                transform.RotateAround(center.transform.position, Vector3.up, RychlostHore * Time.deltaTime);
            }
        }

        if (Vpravo == true)
        {
            if(Delay == true)
            {
                MyDelay += 1;
                if (MyDelay > DelayTime)
                {
                    MyRotateTime += 1;
                    transform.RotateAround(center.transform.position, Vector3.right, RychlostVpravo * Time.deltaTime);
                    if (MyRotateTime == RotateTime)
                    {
                        MyDelay = 0;
                        MyRotateTime = 0;
                    }
                }
            }
            else
            {
                transform.RotateAround(center.transform.position, Vector3.right, RychlostVpravo * Time.deltaTime);
            }
        }

        if (Vpredu == true)
        {
            if(Delay == true)
            {
                MyDelay += 1;
                if (MyDelay > DelayTime)
                {
                    MyRotateTime += 1;
                    transform.RotateAround(center.transform.position, Vector3.forward, RychlostVpredu * Time.deltaTime);
                    if (MyRotateTime == RotateTime)
                    {
                        MyDelay = 0;
                        MyRotateTime = 0;
                    }
                }
            }
            else
            {
                transform.RotateAround(center.transform.position, Vector3.forward, RychlostVpredu * Time.deltaTime);
            }
        }
    }
}
