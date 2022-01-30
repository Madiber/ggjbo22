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
        SaveSFX();
    }
    public void SetMusic(float f)
    {
        audioMixer.SetFloat("MusicVolume", f);
        SaveMusic();
    }

    void SaveSFX()
    {

    }
    void SaveMusic()
    {

    }

    public void LoadSFX()
    {

    }
    public void LoadMusic()
    {

    }
}
