using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public float health;
    public float attackDamage;
    public float rateOfFire;
    public bool canFire;
    float fireTime;


    public GameObject target;
    public Vector3 targetPos;
    public Animator animatorRef;
    public bool inRange;
    public float moveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake() 
    {
        animatorRef.GetComponent<Animator>();
        target = GameObject.Find("Player"); //Although we can drag this into inspector, it's good
        //practice to use code to assign things. Be carefull about how you do it though
        //as some ways are more resource heavier than others
        //ALSO, we need to get all the Input and Colliders/Rigidbody into the Player Parent Object

    }

    // Update is called once per frame
    void Update()
    {
        //Here we continue to update the target (players) position for the enemy so they know where to move 
        //when the player moves
        targetPos = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);

        //Now we actively move the transform.position of the enemy object using Unity's MoveTowards function
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);

        Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        transform.LookAt(targetPosition);

    }



    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            inRange = true;
            animatorRef.SetTrigger("inRange");
            /*if(fireTime >= rateOfFire)
            {
                Attack();
            }*/
            
        }    
    }
    void OnTriggerExit(Collider other) 
    {
        if(other.tag == "Player")
        {
            fireTime = 0; //Resets the fire timer when the player leaves range
            inRange = false;
            animatorRef.SetTrigger("inRange");
        }
    }


    /*void Attack()
    {
        animatorRef.SetTrigger("inRange");
        Debug.Log("rawr!");
    }*/
}
