using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBase : MonoBehaviour
{
    bool isPressed = false;

    public void PressDown()
    {
        isPressed = true;
        OnPressDown();
    }
    public void PressUp()
    {
        isPressed = false;
        OnPressUp();
    }
    private void Update()
    {
        if(isPressed)
        {
            OnTickPressed(Time.deltaTime);
        }
    }
    protected abstract void OnPressDown();
    protected abstract void OnPressUp();
    protected abstract void OnTickPressed(float DeltaTime);
}
