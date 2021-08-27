using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    //public objectPoolSample objectPoolRef;
    //public GameObject DroidThingyPool = new Queue<GameObject>();
    //public float health;
    //public float attackDamage;
    //public float rateOfFire;
    //public bool canFire;
    //float fireTime;


    public GameObject target;
    public Vector3 targetPos;
    public Animator animatorRef;
    public bool inRange;
    //public float moveSpeed;

    public EnemyHealth enemyHealthRef;
    [SerializeField]
    private NavMeshAgent navAgentRef;
    [SerializeField]
    private enemyFollow enemyFollowRef;

    public GameObject healthBorderRef;
    public BoxCollider[] collidersRef;
    public Rigidbody rbRef;

    public float disappearTimer;


    // Start is called before the first frame update
    void Start()
    {
        enemyHealthRef.isAlive = true;
    }

    void Awake() 
    {
        enemyHealthRef = GetComponent<EnemyHealth>();
        animatorRef.GetComponent<Animator>();
        disappearTimer = 5;
        //healthBorderRef = GetComponent<GameObject>();

        enemyFollowRef = this.GetComponent<enemyFollow>();
        navAgentRef = this.GetComponent<NavMeshAgent>();
        collidersRef = this.GetComponents<BoxCollider>();
        rbRef = this.GetComponent<Rigidbody>();
    }


    void Update()
    {

        if(enemyHealthRef.isAlive == false)
        {
            Die();
            disappearTimer -= Time.deltaTime;
            if (disappearTimer <= 0)
            {
                this.gameObject.SetActive(false);
            }
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

        navAgentRef.isStopped = true;
        Destroy(rbRef);
        enemyFollowRef.enabled = false;

        healthBorderRef.SetActive(false);
        //disappearTimer = 5;
        
        for(int i = 0; i < collidersRef.Length; i++)
        {
            collidersRef[i].enabled = false;
        }
    }


}
