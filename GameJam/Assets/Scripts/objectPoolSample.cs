using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectPoolSample : MonoBehaviour
{
    [SerializeField]
    private GameObject DroidThingyPrefab;
    [SerializeField]
    private Queue<GameObject> DroidThingyPool = new Queue<GameObject>();
    [SerializeField]
    private int poolStartSize = 5;



    private void Start()
    {
        for (int i = 0; i < poolStartSize; i++)
        {
            GameObject DroidThingy = Instantiate(DroidThingyPrefab);
            DroidThingyPool.Enqueue(DroidThingy);
            DroidThingy.SetActive(false);
        }
    }

    public GameObject GetDroidThingy()
    {
        if (DroidThingyPool.Count > 0)
        {
            GameObject DroidThingy = DroidThingyPool.Dequeue();
            DroidThingy.SetActive(true);
            return DroidThingy;
        }
        else
        {
            GameObject DroidThingy = Instantiate(DroidThingyPrefab);
            return DroidThingy;
        }
    }
    
    public void ReturnDroidThingy(GameObject DroidThingy)
    {
        DroidThingyPool.Enqueue(DroidThingy);
        DroidThingy.SetActive(false);
    }







}
