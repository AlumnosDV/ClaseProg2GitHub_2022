using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform targetOverride;
    Vector3 offset;

    [Range(1,6)][SerializeField] float cameraspeed;

    void Start()
    {
        if (targetOverride != null)
        {
            offset = targetOverride.position - this.transform.position;
        }
        else
        {
            offset = GameManager.GetPlayer().transform.position - this.transform.position;
        }

    }
    void LateUpdate()
    {
        if (targetOverride != null)
        {
            Vector3 final = targetOverride.position - offset;
            transform.position = Vector3.Slerp(transform.position, final, cameraspeed * Time.deltaTime);
        }
        else
        {
            Vector3 final = GameManager.GetPlayer().transform.position - offset;
            transform.position = Vector3.Slerp(transform.position, final, cameraspeed * Time.deltaTime);
        }
       
    }
}
