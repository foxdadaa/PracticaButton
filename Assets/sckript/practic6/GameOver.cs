using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
public int[] WinNamber;
    public void proverca()
    {
        if(WinNamber[1] == WinNamber[2] && WinNamber[2] == WinNamber[3])
        {
            //написать появление луза
        }
    }
}
