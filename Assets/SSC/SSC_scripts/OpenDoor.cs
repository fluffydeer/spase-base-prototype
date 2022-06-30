using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    public GameObject DvereLave;
    public GameObject DverePrave;
    //public AudioSource Zvuk;
    public GameObject Player;

    public float xpoziciaZaciatok;
    public float xpoziciaCiel;
    public float XKrok;

    public bool spustac;
    public int maxRange;

    public bool x;
    public bool y;
    public bool z;

    private Vector3 mySpawnPointLave;
    private Quaternion mySpawnRotationLave;
    private Vector3 mySpawnPointPrave;
    private Quaternion mySpawnRotationPrave;
    private Vector3 PlayerPosition;



    // Use this for initialization
    void Start () {
        mySpawnPointLave = DvereLave.transform.position;
        mySpawnRotationLave = DvereLave.transform.rotation;

        mySpawnPointPrave = DverePrave.transform.position;
        mySpawnRotationPrave = DverePrave.transform.rotation;
    }
	
	// Update is called once per frame
	void Update () {
		if(spustac == true)
        {
            //OtvorDvere();
        }
        else
        {
            //ZatvorDvere();
        }
        //PlayerPosition = Player.transform.position;
        //print(PlayerPosition);
        if(Vector3.Distance(transform.position, Player.transform.position) < maxRange)
        {
            OtvorDvere();
        }
        else
        {
            ZatvorDvere();
        }
	}

    private void OnCollisionEnter(Collision coll)
    {
        //print("Collider IN je : " + coll.collider);
        if (coll.collider.name == "Player")
        {
            OtvorDvere();
        }
    }

    private void OnCollisionExit(Collision coll)
    {
        //print("Collider OUT je : " + coll.collider);
        if (coll.collider.name == "Player")
        {
            ZatvorDvere();
        }
    }

    private void OtvorDvere()
    {
        if(x == true)
        {
            DvereLave.transform.position = Vector3.MoveTowards(DvereLave.transform.position, new Vector3(mySpawnPointLave.x + xpoziciaCiel, DvereLave.transform.position.y, DvereLave.transform.position.z), XKrok);
            DverePrave.transform.position = Vector3.MoveTowards(DverePrave.transform.position, new Vector3(mySpawnPointPrave.x - xpoziciaCiel, DverePrave.transform.position.y, DverePrave.transform.position.z), XKrok);
        }
        if (y == true)
        {
            DvereLave.transform.position = Vector3.MoveTowards(DvereLave.transform.position, new Vector3(DvereLave.transform.position.x, mySpawnPointLave.y + xpoziciaCiel, DvereLave.transform.position.z), XKrok);
            DverePrave.transform.position = Vector3.MoveTowards(DverePrave.transform.position, new Vector3(DvereLave.transform.position.x, mySpawnPointLave.y - xpoziciaCiel, DverePrave.transform.position.z), XKrok);
        }
        if (z == true)
        {
            DvereLave.transform.position = Vector3.MoveTowards(DvereLave.transform.position, new Vector3(DvereLave.transform.position.x, DvereLave.transform.position.y, mySpawnPointLave.z + xpoziciaCiel), XKrok);
            DverePrave.transform.position = Vector3.MoveTowards(DverePrave.transform.position, new Vector3(DvereLave.transform.position.x, DverePrave.transform.position.y, mySpawnPointLave.z - xpoziciaCiel), XKrok);
        }
        
    }

    private void ZatvorDvere()
    {
            DvereLave.transform.position = Vector3.MoveTowards(DvereLave.transform.position, mySpawnPointLave, XKrok);
            DverePrave.transform.position = Vector3.MoveTowards(DverePrave.transform.position, mySpawnPointPrave, XKrok);   
    }
}
