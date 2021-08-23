using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public float timer0 = 1;
    public GameObject ObjectToSpawn;
          
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer0 -= Time.deltaTime;
            if(timer0 <= 0)
            {
                timer0 = Random.Range(4.0f,12.0f);
                void SpawnEnemy(float angle, float radius)
                    {
                        Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.right;
                        Vector3 spawnPosition = transform.position + direction * radius;
                        Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
                    }

                    EnemyAngle myEnemyAngle = new EnemyAngle(Random.Range(10, 25));

                    SpawnEnemy(myEnemyAngle.NextAngle(), Random.Range(5, 15));
                    SpawnEnemy(myEnemyAngle.NextAngle(), Random.Range(5, 15));
                    SpawnEnemy(myEnemyAngle.NextAngle(), Random.Range(5, 15));
                    SpawnEnemy(myEnemyAngle.NextAngle(), Random.Range(5, 15));
                    SpawnEnemy(myEnemyAngle.NextAngle(), Random.Range(5, 15));
                    SpawnEnemy(myEnemyAngle.NextAngle(), Random.Range(5, 15));

            }





    }

}

 
public class EnemyAngle
{
    int angle;
    int step;

    public EnemyAngle(int increment)
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