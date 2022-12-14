using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public float radius;
    public LayerMask jumpeables;
    bool isgrounded;
    public bool IsGrounded => isgrounded;
    void Update()
    {
        var colliders = Physics.OverlapSphere(transform.position, radius, jumpeables);

        if (colliders.Length > 0)
        {
            isgrounded = true;
        }
        else
        {
            isgrounded = false;
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
