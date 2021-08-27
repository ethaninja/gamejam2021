using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rapierFunction : MonoBehaviour
{
    private Animator animator;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator = GetComponent<Animator>();
            animator.SetTrigger("RapierAttack");            
        }
    }




}
