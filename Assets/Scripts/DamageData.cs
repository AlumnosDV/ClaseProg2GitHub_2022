using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct DamageData
{
    int damage;

    bool hasKnockBack;
    Vector3 direction;

    public int Damage => damage;
    public bool HasKnockBack => hasKnockBack;
    public Vector3 Dir => direction;
    
}
