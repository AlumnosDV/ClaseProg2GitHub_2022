using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitinfo;

            if (Physics.Raycast(ray, out hitinfo))
            {
                DamageData data = new DamageData(20, true, ray.direction);
                IDamageable damageable = hitinfo.collider.GetComponent<IDamageable>();
                if (damageable == null) return;
                damageable.TakeDamage(data);
            }
        }
    }
}
