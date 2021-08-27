using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    //public objectPoolSample objectPoolRef;
    //public GameObject DroidThingyPool = new Queue<GameObject>();
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

    public EnemyHealth enemyHealthRef;
    [SerializeField]
    private NavMeshAgent navAgentRef;
    [SerializeField]
    private enemyFollow enemyFollowRef;

    public BoxCollider[] collidersRef;



    // Start is called before the first frame update
    void Start()
    {
        enemyHealthRef.isAlive = true;
    }

    void Awake() 
    {
        enemyHealthRef = GetComponent<EnemyHealth>();
        animatorRef.GetComponent<Animator>();
        navAgentRef = this.GetComponent<NavMeshAgent>();

        enemyFollowRef = this.GetComponent<enemyFollow>();
        
        collidersRef = this.GetComponents<BoxCollider>();
    }


    void Update()
    {
        if(enemyHealthRef.isAlive == false)
        {
           Die();
        }

    }



    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            inRange = true;
            animatorRef.SetTrigger("inRange");            
        }    
    }
    void OnTriggerExit(Collider other) 
    {
        if(other.tag == "Player")
        {
            inRange = false;
            animatorRef.SetTrigger("inRange");
        }
    }

    void Die()
    {
        //this.gameObject.SetActive(false); //I will use this code in a timer to have 
        //the bodies decay after a certain amount of time
        animatorRef.SetTrigger("isAlive");
        navAgentRef.enabled = false;
        enemyFollowRef.enabled = false;
        for(int i = 0; i < collidersRef.Length; i++)
        {
            collidersRef[i].enabled = false;
        }
    }


}
