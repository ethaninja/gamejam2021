using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody myRigidbody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    [SerializeField]
    private LayerMask groundMask;

    [SerializeField]
    private Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
       moveVelocity = moveInput * moveSpeed; 
       Aim();
          
    }

    void FixedUpdate()
    {
        myRigidbody.velocity = moveVelocity;
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
