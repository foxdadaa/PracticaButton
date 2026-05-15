using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TimerGame : MonoBehaviour
{
    public TMP_Text timerText;
    public GameObject MenuLose;
    public GameObject background;
    public UnityEngine.UI.Button[] buttons;

    private float timeLeft = 10f;
    private bool isRunning = false;
    public void TimerGo()
    {
        isRunning = true;
        timeLeft = 10f;
    }
    void Update()
    {
        if (isRunning && timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = Mathf.CeilToInt(timeLeft).ToString();
            Debug.Log(timerText.text);
            if (timeLeft <= 0)
            {
                isRunning = false;
                GameOver();
            }
        }
    }
    public void GameOver()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(false);
        }
        MenuLose.SetActive(true);
        background.SetActive(false);
    }
}