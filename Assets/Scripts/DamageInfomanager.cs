using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageInfomanager : MonoBehaviour
{
    public static DamageInfomanager instance;
    public PopPupMsg poppupModel;

    private void Awake()
    {
        instance = this;
    }

    public void ShowMessage(Vector3 pos, string msg)
    {
        var poppup = Instantiate(poppupModel);
        poppup.ShowMessage(msg, pos);
    }
}
