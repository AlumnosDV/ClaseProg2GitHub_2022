using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public AudioManager instance;

    [SerializeField]
    private AudioSource audioSource;

    public void PlayAudio(AudioClip clip)
    {
        audioSource.clip = clip;

        audioSource.Play();
    }
}
