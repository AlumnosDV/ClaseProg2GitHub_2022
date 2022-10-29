using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyConcrete : EnemyAgent
{
    float timer;
    float pulse = 3f;

    float time_to_anim = 0.5f;
    float timer_anim_dmg;
    bool anim_dmg;

    Renderer myrender;
    Color original;

    protected override void OnStart()
    {
        base.OnStart();

        myrender = GetComponentInChildren<Renderer>();
        original = myrender.material.GetColor("_Color");
    }

    private void Update()
    {
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hitinfo;
        //    if (Physics.Raycast(ray, out hitinfo))
        //    {
        //        Vector3 pos = hitinfo.point;
        //        MoveTo(pos);
        //    }
        //}
        if (anim_dmg)
        {
            if (timer_anim_dmg < time_to_anim)
            {
                timer_anim_dmg = timer_anim_dmg + 1 * Time.deltaTime;
                myrender.material.SetColor("_Color", Color.Lerp(Color.red, original, timer_anim_dmg/time_to_anim));
            }
            else
            {
                timer_anim_dmg = 0;
                anim_dmg = false;
            }
        }
       


        if (timer < pulse)
        {
            timer = timer + 1 * Time.deltaTime;
        }
        else
        {
            timer = 0;
            MoveTo(GameManager.GetPlayer().gameObject.transform.position);
        }
    }


    protected override void OnDeath() 
    {
        print("La muerte del enemigo conctreto");
    }
    protected override void OnRefresh(float val) 
    {
        print("Enemey mele zaraza fulano");
    }
    protected override void OnTakeDamage() 
    {
        anim_dmg = true;
    }

    protected override void OnHeal()
    {
       
    }
}
