using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapierFunction : MonoBehaviour //IWeapon
{
    
    private Animator animator;
    //public List<BaseStat> Stats { get; set; }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
        animator = GetComponent<Animator>();
        animator.SetTrigger("RapierAttack");
        }
    }
}
