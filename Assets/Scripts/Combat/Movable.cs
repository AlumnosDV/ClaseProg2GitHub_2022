using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movable : MonoBehaviour
{
    public abstract void Move(Vector3 pos, Vector3 dir);
}
