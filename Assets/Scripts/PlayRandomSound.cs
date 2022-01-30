using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomSound : MonoBehaviour
{
    [SerializeField] AudioClip[] Clips;
    [SerializeField] AudioSource source;

    private void OnCollisionEnter(Collision collision)
    {
        PlayRandom();
    }

    void PlayRandom()
    {
        int i = Random.Range(0, Clips.Length - 1);
        float p = Random.Range(.8f, 1.2f);
        source.pitch = p;
        source.clip = Clips[i];
        source.Play();
    }
}
