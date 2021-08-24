using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void ButtonPlay()
    {
        //SceneManager.LoadScene(1);
        Debug.Log("Starting game...");
    }

    
    public void ButtonQuit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
