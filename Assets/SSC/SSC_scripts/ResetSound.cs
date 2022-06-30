using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ResetSound : MonoBehaviour {

    public Slider MasterSound;
    public Slider MusicSound;
    public Slider EffectsSound;

    public AudioMixer MasterMixer;


	public void resetsound()
    {
        MasterSound.value = 0;
        MusicSound.value = 0;
        EffectsSound.value = 0;

        MasterMixer.SetFloat("MasterVol",0f);
        MasterMixer.SetFloat("MusicVol", 0f);
        MasterMixer.SetFloat("SoundEfVol", 0f);
    }
}
