using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Stats : MonoBehaviour
{
    [SerializeField] private TMP_Text points;
    int counter = 0;

    public void pointer()
    {
        points.text = (++counter).ToString();
    }

}
