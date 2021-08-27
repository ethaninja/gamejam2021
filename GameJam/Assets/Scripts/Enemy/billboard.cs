using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billboard : MonoBehaviour
{
   
    //public Transform cam;
    public GameObject cam;
    public GameObject player;

    void Awake()
    {
        var cam = GetComponent<GameObject>();
        
    }
    
    void LateUpdate()
    {
        transform.LookAt(transform.position + cam.transform.position);

    }
}
