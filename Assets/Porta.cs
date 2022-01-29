using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum TEAM { LUPO, CANE}
public class Porta : MonoBehaviour
{
    [SerializeField] TEAM team;
    [SerializeField] TMP_Text labelCane;
    [SerializeField] TMP_Text labelLupo;

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
            Destroy(other.gameObject);
        }
    }

    private void UpdateScore()
    {
        switch (team)
        {
            case TEAM.LUPO:
                labelLupo.text = $"LUPO: {++score}";
                break;
            case TEAM.CANE:
                labelCane.text = $"CANE: {++score}";
                break;
            default:
                break;
        }
    }
}