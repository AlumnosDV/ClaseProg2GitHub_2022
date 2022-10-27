using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    Vector3 offset;

    [Range(1,6)][SerializeField] float cameraspeed;

    void Start()
    {
        offset = GameManager.GetPlayer().transform.position - this.transform.position;
    }
    void LateUpdate()
    {
        Vector3 final = GameManager.GetPlayer().transform.position - offset;
        transform.position = Vector3.Slerp(transform.position, final, cameraspeed * Time.deltaTime);
    }
}
