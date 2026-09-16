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
public Button drel;
public Button molot;
public Button otm;
public Button replaylose;
public Button replaywin;
int random1;
int random2;
int random3;
private void Start()
    {
        random1 = Random.Range(1, 8);
        random2 = Random.Range(1, 8);
        random3 = Random.Range(1, 8);
        Namber1.text = random1.ToString();
        Namber2.text = random2.ToString();
        Namber3.text = random3.ToString();
        //Debug.Log(random1);
    }

    public void Drel()
    {
        int.TryParse(Namber1.text, out int temp1);
        temp1 = temp1 + 1;
        Namber1.text = temp1.ToString();
        int.TryParse(Namber2.text, out int temp2);
        temp2 = temp2 - 1;
        //Debug.Log(temp2);
        Namber2.text = temp2.ToString();
        int.TryParse(Namber3.text, out int temp3);
        gameover.proverca(temp1, temp2, temp3);
    }
    public void Molot()
    {
        int.TryParse(Namber1.text, out int temp1);
        temp1 = temp1 - 1;
        Namber1.text = temp1.ToString();
        int.TryParse(Namber2.text, out int temp2);
        temp2 = temp2 + 2;
        Namber2.text = temp2.ToString();
        int.TryParse(Namber3.text, out int temp3);
        temp3 = temp3 - 1;
        Namber3.text = temp3.ToString();
        gameover.proverca(temp1, temp2, temp3);
    }
        public void Otm()
    {
        int.TryParse(Namber1.text, out int temp1);
        temp1 = temp1 - 1;
        Namber1.text = temp1.ToString();
        int.TryParse(Namber2.text, out int temp2);
        temp2 = temp2 + 1;
        Namber2.text = temp2.ToString();
        int.TryParse(Namber3.text, out int temp3);
        temp3 = temp3 + 1;
        Namber3.text = temp3.ToString();
        gameover.proverca(temp1, temp2, temp3);
    }
        public void Replay()
    {
        Start();
    }
}
