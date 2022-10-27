using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSensor : MonoBehaviour
{

    [SerializeField] int dmg = 10;
    private void OnTriggerEnter(Collider other)
    {
        EnemyBase enemybase = other.GetComponent<EnemyBase>();
        if (enemybase != null)
        {
            enemybase.Hit(dmg);
        }
    }
}
