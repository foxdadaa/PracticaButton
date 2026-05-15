using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class Record : MonoBehaviour

{
    public static int record = 0;
    public TMP_Text recordText;
    int temp = 0;
    public void updeitRecord()
    {
        if(temp < record)
        {
            temp = record;
            recordText.text = temp.ToString();
        }
    Debug.Log(temp);
    }
}