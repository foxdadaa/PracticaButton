using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class timer : MonoBehaviour
{
    public TMP_Text TimerText;
    public GameOver gameover;
    private float TimeLeft = 15f;
    private bool game = false;
    int temp1;
    int temp2;
    int temp3;
    public void Start()
    {
        game = true;
    }
    public void restars()
    {
        TimeLeft = 15f;
        game = true;
    }
    void Update()
    {
        if(game && TimeLeft > 0)
        {
            Debug.Log(TimeLeft);
            TimeLeft -= Time.deltaTime;
            TimerText.text = Mathf.CeilToInt(TimeLeft).ToString();
        }
        else
        {
            temp1 = 0;
            temp2 = 0;
            temp3 = -1;
            game = false;
            gameover.proverca(temp1, temp2, temp3);
        }
    }
}