using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
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
