using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageable : MonoBehaviour, IDamageable
{
    public Gradient gradientColor;
    Renderer myrender;
    float timer;
    public float time_to_damage = 1f;
    bool animdamage;

    public float speed = 5f;

    [SerializeField] Transform hitinfopoint;

    void Awake()
    {
        myrender = GetComponent<Renderer>();
    }

    void IDamageable.TakeDamage(DamageData data)
    {
        animdamage = true;
        timer = 0;
        DamageInfomanager.instance.ShowMessage(hitinfopoint.position, data.Damage.ToString());
    }

    void Update()
    {

        transform.position = transform.position + new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical")).normalized * Time.deltaTime * speed;

        if (animdamage)
        {
            if (timer < time_to_damage)
            {
                timer = timer + 1 * Time.deltaTime;
                myrender.material.SetColor("_EmissionColor", gradientColor.Evaluate(timer));
            }
            else
            {
                timer = 0;
                animdamage = false;
            }

        }
    }
}
