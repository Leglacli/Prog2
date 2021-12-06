using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text hourText;
    [SerializeField] private Text minutesText;
    [SerializeField] private Text secondsText;

    private float hour;
    private float minutes;
    private float seconds;

    private string score;

    private bool finished = false;

    // Update is called once per frame
    void Update()
    {
        if (!finished)
            UpdateTime();
    }

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private void UpdateTime()
    {
        IncreaseSeconds();
    }

    private void IncreaseSeconds()
    {
        if (seconds > 60)
        {
            seconds = 0;
            secondsText.text = "00";
            IncreaseMinutes();
        }
        else
        {
            if (seconds < 10)
            {
                seconds += 1 * Time.deltaTime;
                secondsText.text = "0" + (int)seconds;
            }
            else
            {
                seconds += 1 * Time.deltaTime;
                secondsText.text = "" + (int)seconds;
            }
        }
    }

    private void IncreaseMinutes()
    {
        minutes++;

        if (minutes > 60)
        {
            minutes = 0;
            minutesText.text = "00";
            IncreaseHour();
        }
        else
        {
            if (minutes < 10)
            {
                minutesText.text = "0" + minutes + ":";
            }
            else
            {
                minutesText.text = minutes + ":";
            }
        }
    }

    private void IncreaseHour()
    {
        hour++;

        if (hour < 10)
        {
            hourText.text = "0" + hour + ":";
        }
        else
        {
            hourText.text = hour + ":";
        }
    }

    public void ResetTimer()
    {
        seconds = 0;
        minutes = 0;
        hour = 0;
    }

    public void StopTimer()
    {
        finished = !finished;
    }

    public string GetTime()
    {
        score = "Congratulations! You've finished the game in " + (int)hour + " hours " + (int)minutes + " minutes and " + (int)seconds + " seconds!";
        return score;
    }
}
