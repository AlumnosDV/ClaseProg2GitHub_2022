using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OnStoppedparticle : MonoBehaviour
{
    ParticleSystem myParticle;
    Action _onStoppedparticle;

    void Start()
    {
        
    }

    public void ConfigureCallbackOnStopped(Action onStop)
    {
        var main = myParticle.main;
        main.stopAction = ParticleSystemStopAction.Callback;
        _onStoppedparticle = onStop;
    }

    private void OnParticleSystemStopped()
    {
        _onStoppedparticle?.Invoke();
        print("se detuvo");
    }


}
