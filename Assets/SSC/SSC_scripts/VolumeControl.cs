using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour {

    public AudioMixer Zvuk;
   

    public void nastavmaster(float MasterVol)
    {
        Zvuk.SetFloat("MasterVol",MasterVol);
    }

    public void nastavefekty(float SoundEfVol)
    {
        Zvuk.SetFloat("SoundEfVol", SoundEfVol);
    }

    public void nastavmusic(float MusicVol)
    {
        Zvuk.SetFloat("MusicVol", MusicVol);
    }
}
