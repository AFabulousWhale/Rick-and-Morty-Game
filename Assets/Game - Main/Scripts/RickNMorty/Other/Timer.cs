using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public WinLose _WinLose;

    public GameObject TimeGO;

    public float TimerS = 120f;

    public TMPro.TextMeshProUGUI TimeTMP;

    public int countdownOnce;

    void Start()
    {
        countdownOnce = 0;
        TimerS = 120f;
    }

    void Update()
    {
        int seconds = (int)(TimerS % 60);
        int minutes = (int)(TimerS / 60) % 60;

        string timerString = string.Format("{0:0}:{1:00}", minutes, seconds);

        TimeTMP.text = timerString;

        if (TimerS > 0)
        {
            TimerS -= Time.deltaTime;
        }

        if (_WinLose.fiveTimer && countdownOnce == 1)
        {
            countdownOnce = 2;
        }
    }
}
