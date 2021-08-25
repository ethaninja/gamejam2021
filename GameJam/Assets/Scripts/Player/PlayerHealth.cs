using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public HealthChangerPlayer healthBar;

    public bool isAlive;
    public Timer TimerReference;

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
            TimerReference.stopTimer();
        }
        if(currentHealth > 0)
        {
            isAlive = true;
        }
    }


    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
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
