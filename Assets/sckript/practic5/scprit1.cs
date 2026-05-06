using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class scprit1 : MonoBehaviour
{
    int temp2 = 0;
    int arrat = 0;
    int temp = 0;
    int[] array = new int[14];
    public void first()
    {
        for (int i = 7; i < 22;i++ )
        {
            if(i % 2 == 0)
            {
                temp = i;
                array[arrat] = temp;
                arrat++;
            }
        }
    //Debug.Log(String.Join(", ", array));
        for (int i = 0; i < arrat; i++)
        {
        temp = array[i];
        temp2 = temp + temp2;
        }
        Debug.Log(temp2);
    }
}