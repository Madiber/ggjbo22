using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    [SerializeField] GameObject menu;

    public void Pausa(bool isPausa)
    {
        menu.SetActive(isPausa);
        if (isPausa)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }
}
