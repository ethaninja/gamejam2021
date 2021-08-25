using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestTime : MonoBehaviour
{
    public Text bestTimeMins;
    public Text bestTimeSecs;
    public Timer TimerReference;
    

    // Start is called before the first frame update
    void Awake()
    {
        TimerReference.stopTimer();
        bestTimeMins.text = PlayerPrefs.GetFloat("BestTimeMins", 0).ToString();
        bestTimeSecs.text = PlayerPrefs.GetFloat("BestTimeSecs", 0).ToString("f2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
