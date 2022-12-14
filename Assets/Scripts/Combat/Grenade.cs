using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : Movable
{
    Rigidbody rig;
    [SerializeField] float time = 1;
    [SerializeField] float force = 5;

    public override void Move(Vector3 pos, Vector3 dir)
    {
        rig = GetComponent<Rigidbody>();
        transform.position = pos;
        transform.forward = dir;

        rig.AddForce(transform.forward * force , ForceMode.VelocityChange);

        Invoke("Destroy", time);
    }

    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
