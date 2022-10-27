using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Movable
{
    [SerializeField] float speed = 10;

    [SerializeField] float time = 1f;
    float timer;

    public override void Move(Vector3 pos, Vector3 dir)
    {
        transform.position = pos;
        transform.forward = dir;
    }

    private void Update()
    {
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;

        timer = timer + 1 * Time.deltaTime;
        if (timer > time)
        {
            Destroy(this.gameObject);
        }
    }
}
