using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class igra : MonoBehaviour
{
    public UnityEngine.UI.Button[] buttons;

    public UnityEngine.UI.Button[] game;
    public UnityEngine.UI.Button start2;
    public UnityEngine.UI.Button gameover;
    public Stats stats;
    int counter = 0;
    public void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(false);
        }
        gameover.gameObject.SetActive(false);
    }
    public void StartGame()
    {
        int i = Random.Range(0,14);
        //Debug.Log(i);
        buttons[i].gameObject.SetActive(true);
        start2.gameObject.SetActive(false);
        //Debug.Log(1);
        int temp = i;
        gameover.gameObject.SetActive(true);
    }
    public void Game()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(false);
        }
        int b = Random.Range(0,14);
        buttons[b].gameObject.SetActive(true);
        stats.pointer();
    }
    public void GameOver()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(false);
        }
        start2.gameObject.SetActive(true);
        gameover.gameObject.SetActive(false);
    }
}
