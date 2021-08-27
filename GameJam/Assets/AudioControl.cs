using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public PlayerHealth playerHealthRef;
    public AudioSource mainGame;

    
    // Start is called before the first frame update
    void Start()
    {
        mainGame = GetComponent<AudioSource>();
        //playerHealthRef = GetComponent<PlayerHealth>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealthRef.currentHealth <= 0)
        {
            mainGame.volume = 0;
            mainGame.loop = false;
        }

    }
}
