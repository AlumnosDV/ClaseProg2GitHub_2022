using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopPupMsg : MonoBehaviour
{
    public TextMeshProUGUI mytext;
    public void ShowMessage(string msg, Vector3 intialPos)
    {
        mytext.text = msg;
        transform.position = intialPos;
        pos_i = intialPos;
        pos_f = intialPos + Vector3.up * heigthmultiplier;
        
    }
    float timer = 0;
    public float time_to_destroy = 1f;

    public float speed = 1f;

    public Gradient gradient;

    public float heigthmultiplier = 1;

    Vector3 pos_i;
    Vector3 pos_f;

    public AnimationCurve curve;

    private void Update()
    {
        if (timer < time_to_destroy)
        {
            timer = timer + 1 * Time.deltaTime;
            //transform.position = transform.position + transform.up * Time.deltaTime * speed;

            transform.position = Vector3.Lerp(pos_i, pos_f , curve.Evaluate(timer/time_to_destroy));


            mytext.color = gradient.Evaluate(timer / time_to_destroy);
        }
        else
        {
            timer = 0;
            Destroy(this.gameObject);
        }
    }
}
