using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Transform shoot_point; //punto de disparo
    public Transform my_root;

    public AnimEvents events;
    public PlayerView view;

    public Movable model_bullet;
    public Movable model_granade;
    [SerializeField] MeleeSensor mySensorMelee;

    private void Start()
    {
        events.ADD_EVENT("shoot_attack", RealShoot);
        events.ADD_EVENT("melee_attack_begin", RealBegin_Melee);
        events.ADD_EVENT("melee_attack_end", RealEnd_Melee);
        events.ADD_EVENT("throw_attack", RealThrow);

        mySensorMelee.TurnOff();

        mySensorMelee.Configure(OnDealDamage);
    }

    #region Real events
    void RealShoot()
    {
        var bullet = GameObject.Instantiate(model_bullet);
        bullet.Move(shoot_point.position, my_root.forward);
    }
    void RealBegin_Melee()
    {
        mySensorMelee.TurnOn();
    }
    void RealEnd_Melee()
    {
        mySensorMelee.TurnOff();
    }
    void RealThrow()
    {
        var granade = GameObject.Instantiate(model_granade);
        granade.Move(shoot_point.position, my_root.forward);
    }
    #endregion

    void OnDealDamage(IDamageable dmg)
    {

        //dmg.TakeDamage(dmg);

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            view.ExecuteShoot();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            view.ExecuteGrenade();
        }
        if (Input.GetButtonDown("Fire3"))
        {
            view.ExecuteMelee();
        }
    }
}
