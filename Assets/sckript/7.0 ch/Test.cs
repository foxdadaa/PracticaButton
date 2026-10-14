using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Test : MonoBehaviour
{
    public Button StartButton;
    public float MaxTime = 1;
    private float time;
    public Image timerImage;
    public void Start()
    {
        Debug.Log("Test::Start(); -- timerImage:" + timerImage);
        if (timerImage == null) timerImage = GetComponent<Image>();
        Debug.Log("Test::Start(); -- timerImage:" + timerImage);
        time = MaxTime;
    }

    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0) {
            time = MaxTime;
            Debug.Log("Test::Update(); -- timerImage:" + timerImage);
        }

        // Debug.Log("Test::Update(); -- timerImage:" + timerImage);
        timerImage.fillAmount = time / MaxTime;
    }
}