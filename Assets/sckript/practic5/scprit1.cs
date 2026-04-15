using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class scprit1 : MonoBehaviour
{
    public void Calculate()
    {
        int[] deapozon = new int[17];
        for (int i = 0; i < deapozon.Length; i++)
        {
            if (i > 0)
            {
            deapozon[i] = 6 + i;
            int value = deapozon[i];
            if (value <= 21 && value % 2 == 0)
            {
                deapozon[0] += value;
            }
            if (i == deapozon.Length - 1)
            {
                Debug.Log($"ответ:{i}");
            } 
            }
        }
    }

}