using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRot : MonoBehaviour
{
    [SerializeField] float rotSpeed = 0.01f;

    Vector2 input;

    void Update()
    {
        input = new Vector2(Input.GetAxis("Mouse Y") *-1, Input.GetAxis("Mouse X"));
        this.transform.eulerAngles = this.transform.eulerAngles + (Vector3)input * rotSpeed * Time.deltaTime;
    }
}
