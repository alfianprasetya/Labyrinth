using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    [SerializeField] int minuteCount;
    
    float secondsCount;
    bool timing = true;

    public UnityEvent OnTimerEnd = new UnityEvent();

    public TMP_Text TimerText { get => timerText; }

    void Update()
    {
        if(minuteCount >= 0)
            if(timing)
                UpdateTimer();
            else
                StopTimer();
        else
            OnTimerEnd.Invoke();
    }

    public void UpdateTimer()
    {
        secondsCount -= Time.deltaTime;
        timerText.text = string.Format("{0:00}:{1:00}", minuteCount, secondsCount);
        if (secondsCount <= 0)
        {
            minuteCount --;
            secondsCount = 60;
        }
    }

    public void SetActive(bool value)
    {
        timing = value;
    }

    public string StopTimer()
    {
        return timerText.text;
    }
}
