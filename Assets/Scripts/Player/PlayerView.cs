using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] Animator my_anim;

    private void Start()
    {
        
    }

    public void ExecuteMelee()
    {
        my_anim.Play("anim_melee", 1);
    }

    public void ExecuteShoot()
    {
        my_anim.Play("anim_shoot", 1);
    }

    public void ExecuteGrenade()
    {
        my_anim.Play("anim_throw", 1);
    }

    public void DirView(Vector3 dir_view)
    {
        my_anim.SetFloat("Horizontal", dir_view.x);
        my_anim.SetFloat("Vertical" +
            "", dir_view.z);
    } 
}
