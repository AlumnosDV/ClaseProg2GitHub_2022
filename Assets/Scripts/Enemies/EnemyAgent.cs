using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyAgent : EnemyBase
{
    NavMeshAgent nav;
    protected override void OnStart()
    {
        nav = GetComponent<NavMeshAgent>();
    }
    protected void MoveTo(Vector3 pos)
    {
        nav.destination = pos;
    }

    protected void ShutDownNavMesh()
    {
        nav.enabled = false;
    }
}
