using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScore : MonoBehaviour
{
    [SerializeField] private Text score;
    private Timer timer;

    private void Start()
    {
        timer = GameObject.Find("TimerCanvas").GetComponent<Timer>();
        timer.gameObject.SetActive(false);
        score.text = "" + timer.GetTime();
    }
}
