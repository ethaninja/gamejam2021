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

    public PlayerHealth playerHealthRef;

    //public CharacterController controller;
    //public Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        playerHealthRef = GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealthRef.isAlive == true)
        {
         
            moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
            moveVelocity = moveInput * moveSpeed; 
            myRigidbody.velocity = moveVelocity;
            Aim();
        
        }
       
          
    }

    void FixedUpdate()
    {
        myRigidbody.velocity = moveVelocity;
    }
 private void Aim()
    {
        var (sucess, position) = GetMousePosition();
        //var position = Input.mousePosition;
        if (sucess)
        {
            var direction = position - transform.position;
            direction.y = 0;
            

            transform.forward = direction;
        }
        
    }

    private (bool sucess, Vector3 position) GetMousePosition()
    {
       /* Ray mouseRay = mainCamera.ScreenPointToRay(moveInput.mousePosition);
        float midPoint = (transform.position - mainCamera.transform.position).magnitude * 0.5f;
        transform.LookAtmouse(Ray.Origin + mouseRay.direction * midpoint);*/
        var ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hitInfo, Mathf.Infinity, groundMask))
        {
            return (sucess: true, position: hitInfo.point);
        }
        else
        {
            return(sucess: false, position: Vector3.zero);
        }
    }
    
}
