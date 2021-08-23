using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    
    [SerializeField]
    private LayerMask groundMask;

    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    private Rigidbody rb;
    
   
   Vector3 movement;


    void Start() 
    {
        mainCamera = Camera.main;    
    }

    // Start is called before the first frame update
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");
        Aim();

       // int angle = 50;
       //Vector3 guarding = Quaternion.Euler(0, 0, 0) * Vector3.right;


       /* if(Input.GetMouseButton(0))
        {
            transform.Rotate(0, -50 * Time.deltaTime, 0);
        }
        else 
        {
            transform.Rotate(0, 50 * Time.deltaTime, 0);
        }*/

    }

   
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }



    private void Aim()
    {
        var (sucess, position) = GetMousePosition();
        if(sucess)
        {
            var direction = position - transform.position;
            direction.y = 0;

            transform.forward = direction;
        }
        
    }

    private (bool sucess, Vector3 position) GetMousePosition()
    {
        var ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out var hitInfo, Mathf.Infinity, groundMask))
        {
            return (sucess: true, position: hitInfo.point);
        }
        else
        {
            return(sucess: false, position: Vector3.zero);
        }
    }

}