using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class тестнаарефметику : MonoBehaviour
{
  void Start()
    {

        int a = 2;
        double b = a + 4;
        
        double g = a + b;
        //Debug.Log(b);
        
        g = b - a;
        //Debug.Log(g);

        g = b / a;
        Debug.Log(g);

        g = b % a;
        //Debug.Log(g);
    }
}
