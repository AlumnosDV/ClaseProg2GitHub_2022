using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRifle : WeaponBase
{

    [SerializeField]
    private Transform _shootPoint;

    [SerializeField]
    private float _distance;

    protected override void OnPressDown()
    {
        RaycastHit hit;

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
    }

    protected override void OnTickPressed(float DeltaTime)
    {
        OnPressDown();
    }
}
