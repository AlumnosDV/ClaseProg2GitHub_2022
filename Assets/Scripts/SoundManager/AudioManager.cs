using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField]
    public AudioSource audioSource;

    public void PlayAudio(AudioClip clip)
    {
        audioSource.clip = clip;

        audioSource.Play();
    }
}
