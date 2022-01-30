using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;

    public void SetSFX(float f)
    {
        audioMixer.SetFloat("SFXVolume", f);
    }
    public void SetMusic(float f)
    {
        audioMixer.SetFloat("MusicVolume", f);
    }
}
