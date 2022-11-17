using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        EnemyDamageable enemy = other.GetComponent<EnemyDamageable>();

        if (enemy != null)
        {
            CheckPointManager.instance.SetCheckPoint(this);
        }
    }
}
