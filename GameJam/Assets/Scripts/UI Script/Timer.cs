using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerTextMinutes;
    public Text timerTextSeconds;
    public Text bestTimeMins;
    public Text bestTimeSecs;

    public float timerMinutes;
    public float timerSeconds;

    public bool timerActive;

    public float endTimerMinutes;
    public float endTimerSeconds;


    //Start is called before the first frame update
    void Start()
    {
        bestTimeMins.text = PlayerPrefs.GetFloat("BestTimeMins", 0).ToString();
        bestTimeSecs.text = PlayerPrefs.GetFloat("BestTimeSecs", 0).ToString("f2");
    }

    void Awake()
    {
        timerActive = true;    
    }
    // Update is called once per frame
    void Update()
    {
        if(timerActive == true)
        {

            timerSeconds += 1 * Time.deltaTime;
            timerTextSeconds.text = timerSeconds.ToString("f2");
      
             if(timerSeconds >= 60)
             {
                timerMinutes += 1;
                timerSeconds = 0;
                timerTextMinutes.text = timerMinutes.ToString();      
             }
        }
    }


  public void stopTimer()
   {
       endTimerMinutes = timerMinutes;
       endTimerSeconds = timerSeconds;
       timerActive = false;    
   
        
   if (endTimerMinutes > PlayerPrefs.GetFloat("BestTimeMins", 0))
        {
            PlayerPrefs.SetFloat("BestTimeMins", endTimerMinutes);
            bestTimeMins.text = endTimerMinutes.ToString();
            PlayerPrefs.Save();
            Debug.Log("Savings Mins");
        }

    if (endTimerSeconds > PlayerPrefs.GetFloat("BestTimeSecs", 0))
        {
            PlayerPrefs.SetFloat("BestTimeSecs", endTimerSeconds);
            bestTimeSecs.text = endTimerSeconds.ToString("f2");
            PlayerPrefs.Save();
            Debug.Log("Savings Secs");
        }
    }

   public void ResetMins() 
  {
      PlayerPrefs.DeleteKey("BestTimeMins");
      bestTimeMins.text = "0";
  }      
   
    public void ResetSecs() 
  {
      PlayerPrefs.DeleteKey("BestTimeSecs");
      bestTimeSecs.text = "0";
  } 
}
