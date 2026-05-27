using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
public GameOver gameover;
public TMP_Text Namber1;
public TMP_Text Namber2;
public TMP_Text Namber3;
public Button Button1;
public Button Button2;
public Button Button3;

public void Drel()
    {
        int.TryParse(Namber1.text, out int temp);
        temp = temp + 1;
        Namber1.text = temp.ToString();
        int.TryParse(Namber2.text, out temp);
        temp = temp - 1;
        Namber2.text = temp.ToString();
        gameover.proverca();
    }
    public void molot()
    {
        int.TryParse(Namber1.text, out int temp);
        temp = temp - 1;
        Namber1.text = temp.ToString();
        int.TryParse(Namber2.text, out temp);
        temp = temp + 2;
        Namber2.text = temp.ToString();
        int.TryParse(Namber3.text, out temp);
        temp = temp - 1;
        Namber3.text = temp.ToString();
        gameover.proverca();
    }
        public void otm()
    {
        int.TryParse(Namber1.text, out int temp);
        temp = temp - 1;
        Namber1.text = temp.ToString();
        int.TryParse(Namber2.text, out temp);
        temp = temp + 1;
        Namber2.text = temp.ToString();
        int.TryParse(Namber3.text, out temp);
        temp = temp + 1;
        Namber3.text = temp.ToString();
        gameover.proverca();
    }
}
