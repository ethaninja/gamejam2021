using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverScreen : MonoBehaviour
{
    public void ButtonMainMenu()
    {
        //SceneManager.LoadScene(1);
        Debug.Log("Loading Main Menu...");
    }

    
    public void ButtonQuit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
