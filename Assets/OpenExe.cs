using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using Valve.VR.InteractionSystem;
using System.IO;

[RequireComponent(typeof(Interactable))]
public class OpenExe : MonoBehaviour {
    private Hand.AttachmentFlags attachmentFlags = Hand.defaultAttachmentFlags & (~Hand.AttachmentFlags.SnapOnAttach) & (~Hand.AttachmentFlags.DetachOthers) & (~Hand.AttachmentFlags.VelocityMovement);
    private Interactable interactable;
    public string gameName = "";
    // Use this for initialization
    void Start () {
		
	}
    private void OnAttachedToHand(Hand hand) {
        string exePath = Application.dataPath;
        if (Application.platform == RuntimePlatform.OSXPlayer)
        {
            exePath += "/../../";
        }
        else if (Application.platform == RuntimePlatform.WindowsPlayer)
        {
            exePath += "/../";
        }
        string gamePath;
        ProcessStartInfo startInfo = new ProcessStartInfo();
        gamePath = Application.dataPath + "/Games/" + gameName + ".lnk";
        Process.Start(gamePath, "--args -myarg hardCodedv1");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
