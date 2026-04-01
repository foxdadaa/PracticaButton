using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class input : MonoBehaviour
{
    public TMP_Text counter;
    public TMP_InputField inputField;
    int a = 0;
    private void onPress()
    {
        counter.text = (++a).ToString();
    }
    public void readText()
    {
        counter.text = inputField.text;
    }

}
