using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectReturn : MonoBehaviour
{
    private objectPoolSample objectPool;

    private void Start()
    {
        objectPool = FindObjectOfType<objectPoolSample>();
    }

    private void OnDisable()
    {
        if (objectPool != null)
            objectPool.ReturnDroidThingy(this.gameObject);
    }

}
