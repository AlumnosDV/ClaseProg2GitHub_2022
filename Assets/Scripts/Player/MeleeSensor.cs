using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MeleeSensor : MonoBehaviour
{

    Collider myCol;
    Renderer myRendeer;

    Action<IDamageable> callback;

    private void Start()
    {
        myCol = GetComponent<Collider>();
        myRendeer = GetComponent<Renderer>();
    }

    public void Configure(Action<IDamageable> dmgcbk)
    {
        callback = dmgcbk;
    }

    public void TurnOn()
    {
        myCol.enabled = true;
        myRendeer.enabled = true;
    }
    public void TurnOff()
    {
        myCol.enabled = false;
        myRendeer.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        IDamageable dmg = other.GetComponent<IDamageable>();
        if (dmg != null)
        {
            callback.Invoke(dmg);
        }
    }
}
