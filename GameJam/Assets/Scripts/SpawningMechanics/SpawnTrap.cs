using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrap : MonoBehaviour
{
    public GameObject trapToSpawn;

    // Update is called once per frame
    void Start()
    {

        void SpawnTrap(float angle, float radius)
            {
                Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
                Vector3 spawnPosition = transform.position + direction * radius;
                Instantiate(trapToSpawn, spawnPosition, Quaternion.identity);                        
            }



            TrapAngle myTrapAngle = new TrapAngle(Random.Range(10, 25));

            SpawnTrap(myTrapAngle.NextAngle(), Random.Range(50, 145));
            SpawnTrap(myTrapAngle.NextAngle(), Random.Range(50, 145));
            SpawnTrap(myTrapAngle.NextAngle(), Random.Range(50, 145));
            SpawnTrap(myTrapAngle.NextAngle(), Random.Range(50, 145));
            SpawnTrap(myTrapAngle.NextAngle(), Random.Range(50, 145));
            SpawnTrap(myTrapAngle.NextAngle(), Random.Range(50, 145));
            SpawnTrap(myTrapAngle.NextAngle(), Random.Range(50, 145));
            SpawnTrap(myTrapAngle.NextAngle(), Random.Range(50, 145));
            SpawnTrap(myTrapAngle.NextAngle(), Random.Range(50, 145));
            SpawnTrap(myTrapAngle.NextAngle(), Random.Range(50, 145));

    }

}

 
public class TrapAngle
{
    int angle;
    int step;

    public TrapAngle(int increment)
    {
        angle = Random.Range(15,25);
        step = increment;
        
    }

    public int NextAngle()
    {
        int CurrentAngle = angle;
        angle += Random.Range(0, 360);

        return CurrentAngle; 
    }
}
