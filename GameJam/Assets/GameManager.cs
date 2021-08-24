using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{   
    public static bool GamePaused = false;
    public GameObject PauseMenuUI;

    
    // Update is called once per frame
    //PAUSE MENU
    void Update()
    {

    if (Input.GetKeyDown(KeyCode.Escape))
    {
       if (GamePaused) 
       {
           Resume();
       } else
       {
           Pause();
       }
    }   
 }
    public void Resume()
    {
     PauseMenuUI.SetActive(false);
     Time.timeScale = 1f;
     GamePaused = false;
    }

    void Pause()
    {
     PauseMenuUI.SetActive(true);
     Time.timeScale = 0f;
     GamePaused = true;
    }

 public void LoadMenu()
 {
    Time.timeScale = 1f;
    SceneManager.LoadScene(0); 
 }

 public void QuitGame()
 {
     Debug.Log("Quitting game...");
     Application.Quit();
 }
    

}