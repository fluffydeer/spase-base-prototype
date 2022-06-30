using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CipovanieKarty : MonoBehaviour {

    public bool x;
    public bool y;
    public bool z;

    public float MYmove;
    public float MYstep;
    public GameObject CardReader;
    public GameObject Card;
    public float distance;

    private Vector3 mySpawnPoint;
    private Vector3 mySpawnPoint2;
    private Quaternion mySpawnRotation;

    private float MyTime = 0;

    private bool NotDone = true;
    private bool tmp2 = true;
    private bool tmp1 = true;
    private bool tmp3 = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(Card.transform.position, CardReader.transform.position) < distance)
        {
            if(NotDone == true)
            {
                if(MyTime < 1)
                {
                    mySpawnPoint = Card.transform.position;
                }
                if(MyTime > 7)
                {
                    if (Card.transform.position == mySpawnPoint)
                    {
                        print("NULUJEM");
                        MyTime = 0;
                        NotDone = false;
                        tmp1 = true;
                        tmp2 = true;
                        tmp3 = false;
                    }
                }
                MyTime += Time.deltaTime;
                if (MyTime > 5)
                {
                    if (x == true)
                    {
                        if(tmp1 == true)
                        {
                            Card.transform.position = Vector3.MoveTowards(Card.transform.position, new Vector3(mySpawnPoint.x - MYmove, Card.transform.position.y, Card.transform.position.z), MYstep);
                        }
                       
                        
                        if(Card.transform.position == new Vector3(mySpawnPoint.x - MYmove, Card.transform.position.y, Card.transform.position.z))
                        {
                            tmp1 = false;
                            print("SOM NA MIESTE");
                            if (tmp2 == true)
                            {
                                mySpawnPoint2 = Card.transform.position;
                                print("POINT 1: " + mySpawnPoint + " POINT 2: " + mySpawnPoint2);
                                tmp2 = false;
                            }
                            else
                            {
                                tmp3 = true;
                            }
                        }
                        if(tmp3 == true)
                        {
                            Card.transform.position = Vector3.MoveTowards(Card.transform.position, new Vector3(mySpawnPoint2.x + MYmove, Card.transform.position.y, Card.transform.position.z), MYstep/25);
                        }
                        
                    }

                    if (y == true)
                    {
                        if (tmp1 == true)
                        {
                            Card.transform.position = Vector3.MoveTowards(Card.transform.position, new Vector3(Card.transform.position.x, mySpawnPoint.y - MYmove, Card.transform.position.z), MYstep);
                        }


                        if (Card.transform.position == new Vector3(Card.transform.position.x, mySpawnPoint.y - MYmove, Card.transform.position.z))
                        {
                            tmp1 = false;
                            print("SOM NA MIESTE");
                            if (tmp2 == true)
                            {
                                mySpawnPoint2 = Card.transform.position;
                                print("POINT 1: " + mySpawnPoint + " POINT 2: " + mySpawnPoint2);
                                tmp2 = false;
                            }
                            else
                            {
                                tmp3 = true;
                            }
                        }
                        if (tmp3 == true)
                        {
                            Card.transform.position = Vector3.MoveTowards(Card.transform.position, new Vector3(Card.transform.position.x, mySpawnPoint.y + MYmove, Card.transform.position.z), MYstep / 25);
                        }
                    }

                    if (z == true)
                    {
                        if (tmp1 == true)
                        {
                            Card.transform.position = Vector3.MoveTowards(Card.transform.position, new Vector3(Card.transform.position.x, Card.transform.position.y, mySpawnPoint.z - MYmove), MYstep);
                        }


                        if (Card.transform.position == new Vector3(Card.transform.position.x, Card.transform.position.y, mySpawnPoint.z - MYmove))
                        {
                            tmp1 = false;
                            print("SOM NA MIESTE");
                            if (tmp2 == true)
                            {
                                mySpawnPoint2 = Card.transform.position;
                                print("POINT 1: " + mySpawnPoint + " POINT 2: " + mySpawnPoint2);
                                tmp2 = false;
                            }
                            else
                            {
                                tmp3 = true;
                            }
                        }
                        if (tmp3 == true)
                        {
                            Card.transform.position = Vector3.MoveTowards(Card.transform.position, new Vector3(Card.transform.position.x, Card.transform.position.y, mySpawnPoint.z + MYmove), MYstep / 25);
                        }
                    }

                    //Card.transform.position = Vector3.MoveTowards(Card.transform.position, new Vector3(mySpawnPoint.x + MYmove, Card.transform.position.y, Card.transform.position.z), MYstep);
                    //NacipujKartu();
                    print("Cipujem");
                    
                }
            }
            
        }
        else
        {
            NotDone = true;
            print("Necipujem");
            //MyTime = 0;
        }
    }

    private void NacipujKartu()
    {
        if(x == true)
        {
            Card.transform.position = Vector3.MoveTowards(Card.transform.position, new Vector3(mySpawnPoint.x + MYmove, Card.transform.position.y, Card.transform.position.z), MYstep);
            mySpawnPoint2 = Card.transform.position;
           // Card.transform.position = Vector3.MoveTowards(Card.transform.position, new Vector3(mySpawnPoint2.x - MYmove, Card.transform.position.y, Card.transform.position.z), MYstep);
        }

        if(y == true)
        {
            Card.transform.position = Vector3.MoveTowards(Card.transform.position, new Vector3(Card.transform.position.x, mySpawnPoint.y + MYmove, Card.transform.position.z), MYstep);
            mySpawnPoint2 = Card.transform.position;
            Card.transform.position = Vector3.MoveTowards(Card.transform.position, new Vector3(Card.transform.position.x, mySpawnPoint2.y - MYmove, Card.transform.position.z), MYstep);
        }

        if(z == true)
        {
            Card.transform.position = Vector3.MoveTowards(Card.transform.position, new Vector3(Card.transform.position.x, Card.transform.position.y, mySpawnPoint.z + MYmove), MYstep);
            mySpawnPoint2 = Card.transform.position;
            Card.transform.position = Vector3.MoveTowards(Card.transform.position, new Vector3(Card.transform.position.x, Card.transform.position.y, mySpawnPoint2.z - MYmove), MYstep);
        }

        NotDone = false;
        if(Card.tag == "LevelDone")
        {
            Card.tag = "CanContinue";
        }
        else
        {
            Card.tag = "CantContinue";
        }
        
    }
}
