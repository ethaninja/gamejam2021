using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdPersonMovement : MonoBehaviour
{

    public CharacterController controller;
    public float moveSpeed = 10f;
    private Rigidbody myRigidbody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    public playerHealth playerHealthRef;

    void Update()
    {
        if (playerHealthRef.isAlive == true)
        {
             moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")).normalized;
             moveVelocity = moveInput * moveSpeed;
             myRigidbody.velocity = moveVelocity;

        }
    }
}
