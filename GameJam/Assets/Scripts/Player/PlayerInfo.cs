using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ignore the name PlayerInfo, it was a shit name I just made to have something to start with
public class playerInfo : MonoBehaviour
{
    //I think in here we will have variables specific to the player. We can reference the PlayerInput script
    //in order to modify(override) default values such as speed when the player picks up shit

    public GameObject playerPos;
    public float reactTimer = 0.5f; //How often the target pos in the enemy script will check for your new position

    private void Update() 
    {
        if(reactTimer > 0)
        {
            reactTimer -= Time.deltaTime;
        }    
        if(reactTimer <= 0)
        {
            UpdatePosition();
            reactTimer = 0.5f;
        }
    }

    void UpdatePosition()
    {
        playerPos.transform.position = transform.position; //Now our playerPos will change to the players actual location
        //each time it updates.
    }
}
