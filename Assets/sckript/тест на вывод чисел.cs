using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{ 
    bool myBool = true;
    int myInt = 1;
    float myFloat = 1.6f;
    long myLong  = 16;
    ulong myUlong = 24UL;
    void Start() 
    {
       Debug.Log(myBool);
       Debug.Log(myInt);
       Debug.Log(myFloat);
       Debug.Log(myLong);
       Debug.Log(myUlong);
    } 
}