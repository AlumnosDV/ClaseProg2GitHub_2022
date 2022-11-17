using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] Transform pointToSpawn;

    private void OnTriggerEnter(Collider other)
    {
        EnemyDamageable enemy = other.GetComponent<EnemyDamageable>();
        if (enemy != null)
        {
            enemy.transform.position = pointToSpawn.position;
        }
    }
}
