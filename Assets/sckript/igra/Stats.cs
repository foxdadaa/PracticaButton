using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Stats : MonoBehaviour
{
    [SerializeField] private TMP_Text points;
    [SerializeField] private TMP_Text YourPoints;
    int counter = 0;

    public void pointer()
    {
        points.text = (++counter).ToString();
        YourPoints.text = points.text;
        Record.record = int.Parse(points.text);
    }
    public void pointerm()
    {
        points.text = (counter = 0).ToString();
        YourPoints.text = points.text;
    }

}