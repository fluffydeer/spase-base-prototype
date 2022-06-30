using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour {

    public bool Up;
    public float UpRychlost;

    public bool Right;
    public float RightRychlost;

    public bool Forward;
    public float ForwardRychlost;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rotate();
	}

    void Rotate()
    {
        if(Up == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * UpRychlost);
        }

        if (Right == true)
        {
            transform.Rotate(Vector3.right * Time.deltaTime * RightRychlost);
        }

        if (Forward == true)
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * ForwardRychlost);
        }
    }
}
