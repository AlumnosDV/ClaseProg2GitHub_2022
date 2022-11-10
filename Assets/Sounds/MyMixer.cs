using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MyMixer : MonoBehaviour
{
    [SerializeField] AudioMixer general;


    void Start()
    {
        
    }

    public void Slidergenral(float val)
    {
        float log = 0f;
        if (val < 0.01f)
        {
            val = 0.01f;
        }

        log = Mathf.Log(val) * 20;

        general.SetFloat("General", log);
    }
    public void SliderMusic(float val)
    {
        float log = Mathf.Log(val) * 20;
        general.SetFloat("Music", log);
    }
    public void SliderAmbient(float val)
    {
        float log = Mathf.Log(val) * 20;
        general.SetFloat("Ambient", log);
    }
    public void SliderFX(float val)
    {
        float log = Mathf.Log(val) * 20;
        general.SetFloat("FX", log);
    }
}
