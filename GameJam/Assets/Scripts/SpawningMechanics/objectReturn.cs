using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReturn : MonoBehaviour
{
    private ObjectPoolSample objectPool;

    private void Start()
    {
        objectPool = FindObjectOfType<ObjectPoolSample>();
    }

    private void OnDisable()
    {
        if (objectPool != null)
            objectPool.ReturnDroidThingy(this.gameObject);
    }

}
