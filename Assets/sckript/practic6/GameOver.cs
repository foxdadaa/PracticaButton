using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
public GameObject Winmenu1;
    public void proverca(int temp1, int temp2, int temp3)
    {
        if(temp1 == temp2 && temp2 == temp3)
        {
            Winmenu1.SetActive(!Winmenu1.activeSelf);
            //написать появление луза
        }
    }
}
