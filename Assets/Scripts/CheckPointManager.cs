using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{

    public static CheckPointManager instance;
    private void Awake()
    {
        instance = this;
    }

    Checkpoint current;

    public void SetCheckPoint(Checkpoint _current)
    {
        if (current == null) current = _current;
        else
        {
            if (!current.Equals(_current))
            {
                current = _current;
            }
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            LoadCheckPOint();
        }
    }
    public void LoadCheckPOint()
    {
        EnemyDamageable enemy = FindObjectOfType<EnemyDamageable>();
        enemy.transform.position = current.transform.position;
    }
}
