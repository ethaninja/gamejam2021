using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float health;
    public bool inRange;

    public Animator animatorRef;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake() 
    {
        animatorRef.GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            inRange = true;
            Debug.Log(inRange);
            animatorRef.SetTrigger("inRange");
        }    
    }
    void OnTriggerExit(Collider other) 
    {
        if(other.tag == "Player")
        {
            inRange = false;
            Debug.Log(inRange);
            animatorRef.SetTrigger("inRange");
        }
    }
}
