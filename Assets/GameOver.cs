using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] GameObject[] ActivateOnWin;
    [SerializeField] GameObject[] DeactivateOnWin;
    [SerializeField] Text fraseWin;
    [SerializeField] Porta portaLupo;
    [SerializeField] Porta portaCane;
    [SerializeField] GameObject portraitCane;
    [SerializeField] GameObject portraitLupo;

    [SerializeField] AudioSource source;
    [SerializeField] AudioClip sfxLupo;
    [SerializeField] AudioClip sfxCane;

    public void SetGameOver()
    {
        Debug.Log("GameOver");
        foreach (GameObject go in ActivateOnWin)
        {
            go.SetActive(true);
        }
        foreach (GameObject go in DeactivateOnWin)
        {
            go.SetActive(false);
        }

        fraseWin.text = $"The vegan wolf against animal cruelty has successfully rescued {portaLupo.GetPunteggio()} sheeps!";
        fraseWin.text += $"\nThe guard dog, blind follower of his master's order, has successfully put in jail {portaCane.GetPunteggio()} sheeps!";

        if (portaLupo.GetPunteggio() > portaCane.GetPunteggio())
        {
            source.clip = sfxLupo;
            source.Play();
            portraitCane.transform.localScale = new Vector3(.6f, .6f, .6f);
        }
        else if (portaLupo.GetPunteggio() < portaCane.GetPunteggio())
        {
            source.clip = sfxCane;
            source.Play();
            portraitLupo.transform.localScale = new Vector3(.6f, .6f, .6f);
        }        
    }
}
