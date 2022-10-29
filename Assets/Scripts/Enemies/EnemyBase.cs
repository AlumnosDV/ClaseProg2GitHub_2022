using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class EnemyBase : MonoBehaviour
{
    [SerializeField] int lifemax;
    LifeComponent lifeComponent;
    [SerializeField] Image lifefillui;

    private void Start()
    {
        OnStart();
    }

    void Awake()
    {
        lifeComponent = new LifeComponent(lifemax);
        lifeComponent.Configure(Death, Refresh, OnHeal);
    }


    void Heal()
    {

    }
    public void Hit(int damage) 
    {
        if (lifeComponent.Hit(damage))
        {
            OnTakeDamage();
        }
    }
    void Death() 
    {
        OnDeath();
    }
    void Refresh(float val) 
    {
        lifefillui.fillAmount = val;
        OnRefresh(val); 
    }
    protected abstract void OnStart();
    protected abstract void OnDeath();
    protected abstract void OnRefresh(float val);
    protected abstract void OnTakeDamage();
    protected abstract void OnHeal();
}
