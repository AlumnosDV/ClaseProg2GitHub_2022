using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LifeComponent 
{
    int life = 0;
    int life_max = 0;
    Action callback_death; 
    Action<float> callback_refresh;
    Action callbackHeal;

    public LifeComponent(int life, int life_max)
    {
        this.life = life;
        this.life_max = life_max;
    }
    public LifeComponent(int life_max)
    {
        this.life = life_max;
        this.life_max = life_max;
    }

    public void Configure(Action _cbk_death, Action<float> _cbk_refresh, Action onHeal)
    {
        callback_death = _cbk_death;
        callback_refresh = _cbk_refresh;
        callbackHeal = onHeal;
        Refresh();
    }

    public bool Hit(int damage)
    {
        life -= damage;

        if (life <= 0)
        {
            life = 0;
            callback_death?.Invoke();
            Refresh();
            return false;
        }
        else
        {
            Refresh();
            return true;
        }

        
    }
    public void InstaKill()
    {
        callback_death?.Invoke(); 
        Refresh();
    }
    public void Heal(int heal)
    {
        life += heal;
        if (life > life_max)
        {
            life = life_max;
        }
        else
        {
            callbackHeal.Invoke();
        }
        Refresh();
    }

    void Refresh()
    {
        float amount = (float)life / (float)life_max;
        callback_refresh?.Invoke(amount);
    }

    public void Resurrect()
    {
        life = life_max;
    }
}
