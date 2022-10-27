using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    WeaponBase[] myWeapons = new WeaponBase[0];
    WeaponBase current;
    int index = 0;

    private void Awake()
    {
        myWeapons = GetComponentsInChildren<WeaponBase>();

    }

    private void Start()
    {
        if (myWeapons.Length <= 0) return;
        index = 0;
        current = myWeapons[index];
    }

    void Next()
    {
        if (current == null) return;
        current.OnDeactive();
        index++;
        if (index >= myWeapons.Length)
        {
            index = myWeapons.Length - 1;
        }
        current = myWeapons[index];
        current.OnActive();
    }

    void Back()
    {
        if (current == null) return;
        current.OnDeactive();
        index--;
        if (index < 0)
        {
            index = 0;
        }
        current = myWeapons[index];
        current.OnActive();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Next();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            Back();
        }

        if (current != null)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                current.PressDown();
            }
            if (Input.GetButtonUp("Fire1"))
            {
                current.PressUp();
            }
        }


    }
}
