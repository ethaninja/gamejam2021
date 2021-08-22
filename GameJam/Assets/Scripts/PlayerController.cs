using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
        

    public Rigidbody rb;
    [SerializeField]
   
   Vector3 movement;

    // Start is called before the first frame update
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");

       // int angle = 50;
       //Vector3 guarding = Quaternion.Euler(0, 0, 0) * Vector3.right;


        if(Input.GetMouseButton(0))
        {
            transform.Rotate(0, -50 * Time.deltaTime, 0);
        }
        else 
        {
            transform.Rotate(0, 50 * Time.deltaTime, 0);
        }

    }

   
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

}