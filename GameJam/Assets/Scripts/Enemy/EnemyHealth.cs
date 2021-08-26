using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int maxHealth = 50;
    public int currentHealth;

    public HealthChangerEnemy healthBar;

    public bool isAlive;


    // Start is called before the first frame update
    void Start()
    {
        //healthBar = this.GetComponent<HealthChanger>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if(currentHealth <= 0)
        {
            isAlive = false;

        }
        if(currentHealth > 0)
        {
            isAlive = true;
        }
    }


    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Rapier")
        {
            TakeDamage(5);
        }
        if(currentHealth < 0)
        {
            currentHealth = 0;
            
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
