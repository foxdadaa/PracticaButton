using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class script2 : MonoBehaviour
{
        int array2 = 0;
    int temp2 = 0;
    int temp = 0;
    int[] cashe = new int[10];
    int[] array = new int[10]{ 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
    public void two()
    {
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] % 2 == 0)
            {
                cashe[i] = array[i];
            }
        }
    //Debug.Log(String.Join(", ", cashe));
        for (int i = 0; i < cashe.Length; i++)
        {
            temp = cashe[i];
            temp2 = temp + temp2;
        }
        Debug.Log(temp2);
    }
}
