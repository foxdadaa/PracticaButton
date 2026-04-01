using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie3 : MonoBehaviour
{
    int q = 2;
    int w = 3;
    int stock = 20;

    string Nameproduct = "ручка";
    int price = 4;

    void Start()
    {
        int f = q + w;
        int g = q / w;
        int h = q * w;
        int total = stock * price;
        //Debug.Log("товар: " + Nameproduct + ", общая цена: " + total + " руб.");
        //Debug.Log($"товар: {Nameproduct}, общая цена: {total} руб.");
        //Debug.Log($"{f} {g} {h}");
    }
}
