using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class chelenge : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private TMP_InputField inputField;

    private int randomn;

    private void Start()
    {
        randomn = Random.Range(0, 101);
    }

    public void CheckNumber()
    {
        int userInput;
        if (int.TryParse(inputField.text, out userInput))
        {
            if (userInput < randomn)
            {
                text.text = "      больше";
            }
            else if (userInput > randomn)
            {
                text.text = "      меньше";
            }
            else
            {
                text.text = "    ты угадал!";
            }
        }
        else
        {
            text.text = "введи число от 0 до 100";
        }
    }
}