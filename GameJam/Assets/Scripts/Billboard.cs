using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    //public Transform cam;
    public GameObject cam;

    void Awake()
    {
        cam = this.GetComponent<GameObject>();
        
    }
    
    void LateUpdate()
    {
        transform.LookAt(transform.position + cam.transform.forward);

    }
}
