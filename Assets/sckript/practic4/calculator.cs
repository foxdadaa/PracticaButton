using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net.Mail;
public class calculator : MonoBehaviour
{
    [SerializeField] private TMP_InputField firstinp;
    [SerializeField] private TMP_Text firsttext;
    //[SerializeField] private TMP_Text secondtext;
    [SerializeField] private TMP_InputField secondinp;
    //не забыть доделать через onclick
       int a = 0;
    public void onPressplus()
    {
        int otv1, otv2;
        int.TryParse(firstinp.text , out otv1);
        int.TryParse(secondinp.text , out otv2);

        int sum = otv1 + otv2;
        if (firsttext != null)
            firsttext.text = sum.ToString();
        else
            firsttext.text = sum.ToString();
    }
    public void onPressminus()
    {
        int otv1, otv2;
        int.TryParse(firstinp.text , out otv1);
        int.TryParse(secondinp.text , out otv2);
        int sum = otv1 - otv2;
        if (firsttext != null)
            firsttext.text = sum.ToString();
        else
            firsttext.text = sum.ToString();
    }
    public void onPressymnoj()
    {
        int otv1, otv2;
        int.TryParse(firstinp.text , out otv1);
        int.TryParse(secondinp.text , out otv2);
        int sum = otv1 * otv2;
        if (firsttext != null)
            firsttext.text = sum.ToString();
        else
            firsttext.text = sum.ToString();
    }
    public void onPressdel()
    {
        int otv1, otv2;
        int.TryParse(firstinp.text , out otv1);
        int.TryParse(secondinp.text , out otv2);
        if (otv2 == 0)
        {
            firsttext.text = "на ноль нельзя делить";
            return;
        }
        int sum = otv1 / otv2;
        if (firsttext != null)
            firsttext.text = sum.ToString();
        else
            firsttext.text = sum.ToString();
    }




}
