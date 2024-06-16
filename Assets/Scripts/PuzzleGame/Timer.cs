using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
public class Timer : MonoBehaviour
{
    public float timerDuration = 60f; // Timer süresi (saniye cinsinden)
    public float timer;
    private bool isTimerRunning = false;

    public TextMeshProUGUI timerText; // Eğer bir UI Text gösterecekseniz

    void Start()
    {
        timer = timerDuration;
        isTimerRunning = true;
    }

    void Update()
    {
        if (isTimerRunning)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                DisplayTime(timer);
            }
            else
            {
                timer = 0;
                isTimerRunning = false;
                TimerEnded();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1; // Yuvarlama için

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void TimerEnded()
    {
        // Timer bittiğinde yapılacak işlemler
        Debug.Log("Timer Ended!");
    }

    public void StartTimer()
    {
        timer = timerDuration;
        isTimerRunning = true;
    }

    public void StopTimer()
    {
        isTimerRunning = false;
    }
}
