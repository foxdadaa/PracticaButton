
using TMPro;
using UnityEngine;
using System;

public class calculator : MonoBehaviour
{
    [SerializeField] private TMP_InputField firstInputField;
    [SerializeField] private TMP_InputField secondInputField;
    [SerializeField] private TMP_Text resultText;

    public void OnPressPlus()
    {
        if (int.TryParse(firstInputField.text, out int otv1) &&
            int.TryParse(secondInputField.text, out int otv2))
        {
            int sum = otv1 + otv2;
            if (resultText != null) {
                resultText.text = sum.ToString();
            } else {
                resultText.text = sum.ToString();
            }
        }
    }
    public void onPressminus()
    {
        int otv1, otv2;
        int.TryParse(firstInputField.text , out otv1);
        int.TryParse(secondInputField.text , out otv2);
        int sum = otv1 - otv2;
        if (resultText != null)
            resultText.text = sum.ToString();
        else
            resultText.text = sum.ToString();
    }
    public void onPressymnoj()
    {
        int otv1, otv2;
        int.TryParse(firstInputField.text , out otv1);
        int.TryParse(secondInputField.text , out otv2);
        int sum = otv1 * otv2;
        if (resultText != null)
            resultText.text = sum.ToString();
        else
            resultText.text = sum.ToString();
    }
    public void onPressdel()
    {
        int otv1, otv2;
        int.TryParse(firstInputField.text , out otv1);
        int.TryParse(secondInputField.text , out otv2);
        if (otv2 == 0)
        {
            resultText.text = "на ноль нельзя делить";
            return;
        }
        int sum = otv1 / otv2;
        if (resultText != null)
            resultText.text = sum.ToString();
        else
            resultText.text = sum.ToString();
    }




}
