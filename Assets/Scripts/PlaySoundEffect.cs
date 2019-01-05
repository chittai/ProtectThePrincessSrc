using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundEffect : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip soundEffect;

    public void Sound()
    {
        audioSource.clip = soundEffect;
        audioSource.Play();
    }
}

