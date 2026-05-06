using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class script3 : MonoBehaviour
{
    int temp;
    int f = 35;
    int[] array = new int[10]{ 81, 22, 13, 54, 10, 34, 15, 26, 71, 68 };
    public void three()
    {
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == f)
            {
                temp = i;
                break;
            }
            else
            {
                temp = -1;
            }
        }
        Debug.Log(temp);
    }
}
