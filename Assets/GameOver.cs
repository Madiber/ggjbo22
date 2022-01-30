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

        if (portaLupo.GetPunteggio() > portaCane.GetPunteggio())
        {
            fraseWin.text = "The vegan wolf against animal cruelty\nhas successfully rescued the sheeps!";
        }
        else
            fraseWin.text = "The guard dog, blind follower of his master's order,\nhas successfully put in jail the sheeps!";
    }
}
