using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyFollow : MonoBehaviour
{
    public NavMeshAgent enemyNavRef;
    public Transform Player;
    public EnemyHealth enemyHealthRef;

    // Start is called before the first frame update
    void Start()
    {
        
        Player = GameObject.Find("Player").transform;
    }
    void Awake()
    {
        enemyHealthRef = this.GetComponent<EnemyHealth>();
        enemyNavRef = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyNavRef.destination = Player.position;
         //Okay so it's not here that's causing it to spin on death
        
    }
}
