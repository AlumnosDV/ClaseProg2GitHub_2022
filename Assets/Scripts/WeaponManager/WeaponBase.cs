using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class WeaponBase : MonoBehaviour
{
    bool isPressed = false;

    public abstract void OnActive();
    public abstract void OnDeactive();

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
