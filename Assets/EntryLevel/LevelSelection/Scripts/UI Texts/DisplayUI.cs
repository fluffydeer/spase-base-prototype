using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayUI : MonoBehaviour {

    private Valve.VR.InteractionSystem.Hand hand;
    public string textToBeShown = "";

    private void OnAttachedToHand(Valve.VR.InteractionSystem.Hand attachedHand)
    {
        hand = attachedHand;
        show(textToBeShown);
    }

    private void OnDetachedFromHand(Valve.VR.InteractionSystem.Hand detachedHand)
    {
        hand = detachedHand;
        hide();
    }

    public void show(string text)
    {
        GameObject gameObject = getTextGameObjectFromHand(hand);
        GameObject parentGameObject = gameObject.transform.parent.gameObject;
        Text t = gameObject.GetComponent<Text>();
        parentGameObject.SetActive(true);
        gameObject.SetActive(true);
        t.text = text;
    }

    public void hide()
    {
        GameObject gameObject = getTextGameObjectFromHand(hand);
        GameObject parentGameObject = gameObject.transform.parent.gameObject;
        Text t = gameObject.GetComponent<Text>();
        parentGameObject.SetActive(false);
        gameObject.SetActive(false);
        t.text = "";
    }

    private GameObject getTextGameObjectFromHand(Valve.VR.InteractionSystem.Hand hand)
    {
        return hand.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
