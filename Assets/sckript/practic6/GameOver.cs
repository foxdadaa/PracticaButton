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
        else if(temp1 < 0 || temp2 < 0 || temp3 < 0)
        {
            lose();
        }
        else if(temp1 >= 10 || temp2 >= 10 || temp3 >= 10)
        {
            lose();
        }
    }
    public void lose()
    {
        //Losemenu.SetActive = 
    }
}
