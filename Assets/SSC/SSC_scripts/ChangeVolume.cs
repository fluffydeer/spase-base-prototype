﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour {

    public Slider volumeSlider;
    public AudioSource volumeAudio;
    public void VolumeControler()
    {
        volumeAudio.volume = volumeSlider.value;
    }
	
}
