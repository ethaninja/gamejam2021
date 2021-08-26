using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectPoolSample : MonoBehaviour
{
    [SerializeField]
    private GameObject DroidThingyPrefab;
    [SerializeField]
    public Queue<GameObject> DroidThingyPool = new Queue<GameObject>();
    [SerializeField]
    private int poolStartSize = 5;



    private void Start()
    {
        //creating droid thingy as deactive in queue
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
            //takikng object from queue and activationg it in game scene
            GameObject DroidThingy = DroidThingyPool.Dequeue();
            DroidThingy.SetActive(true);
            return DroidThingy;
        }
        else
        {
            //if queue has <= 0 GameObject<Droid Thingy> it will create one in the scene to keep equilibrium
            GameObject DroidThingy = Instantiate(DroidThingyPrefab);
            return DroidThingy;
        }
    }
    
    public void ReturnDroidThingy(GameObject DroidThingy)
    {
        //puts a clone of the prefab back into queue and deactivates it
        DroidThingyPool.Enqueue(DroidThingy);
        DroidThingy.SetActive(false);
    }







}
