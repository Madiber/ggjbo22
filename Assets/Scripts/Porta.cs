using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum TEAM { LUPO, CANE}
public class Porta : MonoBehaviour
{
    [SerializeField] TEAM team;
    [SerializeField] TMP_Text labelCane;
    [SerializeField] TMP_Text labelLupo;
    [SerializeField] Text labelCaneWin;
    [SerializeField] Text labelLupoWin;
    [SerializeField] Animator cancello;

    public GameOver gameOver;

    public float timeToOpen = 4;

    int score = -1;

    private void Start()
    {
        UpdateScore();
    }
       

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pecora")
        {
            UpdateScore();
            ChiudiCancello();
            Destroy(other.gameObject);
        }
    }

    private void ChiudiCancello()
    {
        cancello.SetBool("isOpen", false);
        StartCoroutine(WaitToOpen());
    }

    IEnumerator WaitToOpen()
    {
        yield return new WaitForSeconds(timeToOpen);
        cancello.SetBool("isOpen", true);
    }

    private void UpdateScore()
    {
        switch (team)
        {
            case TEAM.LUPO:
                labelLupo.text = $"{++score}";
                labelLupoWin.text = $"Wolf saved\n{score} sheeps.";
                break;
            case TEAM.CANE:
                labelCane.text = $"{++score}";
                labelCaneWin.text = $"Dog enslaved\n{score} sheeps.";

                break;
            default:
                break;
        }
        if (ContaPecore() <= 1)
        {
            gameOver.SetGameOver();
        }
            
    }

    public int GetPunteggio()
    {
        return score;
    }

    int ContaPecore()
    {
        Transform p = GameObject.Find("Pecore").transform;
        return p.childCount;
    }

}