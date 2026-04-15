
using TMPro;
using UnityEngine;
using System;

public class TwoNumber : MonoBehaviour
{
    [SerializeField] private TMP_InputField secouninputfield;
    [SerializeField] private TMP_InputField firstinputfield;
    [SerializeField] private TMP_Text textotv;
    int otv1;
    int otv2;
    public void OnClickComparer()
    {
        if (int.TryParse(firstinputfield.text, out otv1) &&
           int.TryParse(secouninputfield.text, out otv2))
        {
            if(otv1 > otv2)
            {
                textotv.text = otv1.ToString();
            }
            else
            { if(otv1 < otv2)
                {
                    textotv.text = otv2.ToString();
                }
                    else
                    {
                        textotv.text = "числа равны";
                    }
            }
                    
         }
        
    }
}
