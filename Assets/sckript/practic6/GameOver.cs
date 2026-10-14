using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class GameOver : MonoBehaviour
{
public GameObject Winmenu1;
public timer Timer;
public GameObject Losemenu;
    public void proverca(int temp1, int temp2, int temp3)
    {
        if(temp1 == temp2 && temp2 == temp3)
        {
            Winmenu1.SetActive(!Winmenu1.activeSelf);
        }
        bool isLose = (temp1 <= 0 || temp2 <= 0 || temp3 <= 0) || (temp1 >= 10 || temp2 >= 10 || temp3 >= 10);
        Losemenu.SetActive(isLose);
    }
}
