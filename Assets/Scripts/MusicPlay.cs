using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour
{
    [SerializeField] AudioSource _myAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
            _myAudio.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Player>())
            _myAudio.Stop();
    }
}
