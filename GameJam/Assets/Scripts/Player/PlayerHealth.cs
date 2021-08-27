using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public HealthChangerPlayer healthBar;

    public bool isAlive;
    public Timer timerReference;
    public GameObject gameOver;

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
            timerReference.stopTimer();
            gameOver.SetActive(enabled);
            Time.timeScale = 0f;
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
        if (other.gameObject.tag == "Trap1")
        {
            TakeDamage(10);
        }

        if (currentHealth < 0)
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
