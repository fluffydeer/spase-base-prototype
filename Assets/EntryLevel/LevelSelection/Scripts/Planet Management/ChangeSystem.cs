using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSystem : MonoBehaviour {

    public SolarSystemGenerationManager.ChangeDirection changeDirection;

    public SolarSystemGenerationManager managerReference;

    // Use this for initialization
    void Start () {
		if(managerReference == null)
        {
            throw new System.Exception("No manager reference in 'ChangeSystem' script");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void OnHandHoverBegin(Valve.VR.InteractionSystem.Hand hand)
    {
        hand.ShowGrabHint();
    }

    protected virtual void OnHandHoverEnd(Valve.VR.InteractionSystem.Hand hand)
    {
        hand.HideGrabHint();
    }

    private void OnAttachedToHand(Valve.VR.InteractionSystem.Hand attachedHand)
    {
        managerReference.ChangeActiveSolarSystem(changeDirection);
    }
}
