using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRifle : WeaponBase
{

    [SerializeField]
    private Transform _shootPoint;

    [SerializeField]
    private float _distance;

    public override void OnActive()
    {
        //Hago ruidos de rifle activo
    }

    public override void OnDeactive()
    {
        //Dejo de hacer ruidos de rifle
    }

    protected override void OnPressDown()
    {
        RaycastHit hit;

        OnActive();

        if (Physics.Raycast(_shootPoint.position, _shootPoint.forward, out hit, _distance))
        {
            var damageable = hit.collider.GetComponent<IDamageable>();

            if(damageable != null)
            {
                Debug.Log("Le pegué");
            }            
        }
    }

    protected override void OnPressUp()
    {
        Debug.Log("No pego más");
        OnDeactive();   
    }

    protected override void OnTickPressed(float DeltaTime)
    {
        OnPressDown();
    }
}
