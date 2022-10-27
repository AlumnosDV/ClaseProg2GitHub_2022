using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody myRig;
    [SerializeField] float speed;
    [SerializeField] PlayerView view;
    [SerializeField] Transform root;

    [SerializeField] GroundSensor groundsensor;

    public float jumpforce = 10;

    void Start()
    {
        myRig = GetComponent<Rigidbody>();
    }

    Vector3 input;
    private void Update()
    {
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 dirview = root.InverseTransformDirection(input);
        view.DirView(dirview);

        if (Input.GetButtonDown("Jump") && groundsensor.IsGrounded)
        {
            myRig.AddForce(Vector3.up * jumpforce , ForceMode.VelocityChange);
        }
    }

    private void FixedUpdate()
    {
        float yaxis = myRig.velocity.y;
        myRig.velocity = input * speed * Time.fixedDeltaTime;
        myRig.velocity = new Vector3(myRig.velocity.x,yaxis,myRig.velocity.z);
    }
}