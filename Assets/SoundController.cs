using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] AudioSource sourceLupo;
    [SerializeField] AudioSource sourceCane;
    [SerializeField] AudioSource sourceNeutra;
    [SerializeField] Porta portaLupo;
    [SerializeField] Porta portaCane;
    public float timer = 4;
    float t;

    private void Start()
    {
        sourceCane.volume = 0;
        sourceLupo.volume = 0;
    }

    private void Update()
    {
        t -= Time.deltaTime;
        if(t<=0)
        {
            t = timer;
            CheckPunteggio();
        }
    }

    public void CheckPunteggio()
    {
        if(portaLupo.GetPunteggio() > portaCane.GetPunteggio())
        {
            sourceCane.volume = 0;
            sourceLupo.volume = .3f;
            if(portaLupo.GetPunteggio() - portaCane.GetPunteggio() > 5)
                sourceLupo.volume = .6f;
            if (portaLupo.GetPunteggio() - portaCane.GetPunteggio() > 10)
                sourceLupo.volume = 1f;
        }

        else if (portaLupo.GetPunteggio() < portaCane.GetPunteggio())
        {
            sourceLupo.volume = 0;
            sourceCane.volume = .3f;
            if (portaCane.GetPunteggio() - portaLupo.GetPunteggio() > 5)
                sourceCane.volume = .6f;
            if (portaCane.GetPunteggio() - portaLupo.GetPunteggio() > 10)
                sourceCane.volume = 1f;
        }
    }
}