using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BurglarGame : MonoBehaviour {
    public float timerTimeMax = 30f;
    public float timerTime = 0f;
    public int[] pins = new int[3];
    public int[] pinsWin = new[] { 6, 5, 3 };
    // public static int[] pinsWinRandom = new[] { 6, 5, 3 };
    // public List<List<int>> tools = new List<List<int>>();
    [System.Serializable]
    public class ToolNameAndPinsClass {
        public string toolName;
        public List<int> pins;
        public override string ToString() {
            Debug.Log("ToolNameAndPinsClass:" + JsonUtility.ToJson(this));
            StringBuilder stringBuilder = new StringBuilder();
            // stringBuilder.Append(toolName + "\n");
            foreach (int pin in pins) {
                stringBuilder.Append(((pin > 0) ? "+" : "") + pin + "|");
            }
            // stringBuilder.Remove(stringBuilder.Length - 2, 1);
            stringBuilder.Append("\n" + toolName);
            return stringBuilder.ToString();
        }
    }
    public List<ToolNameAndPinsClass> tools = new List<ToolNameAndPinsClass>();
    public TMP_Text timerTextTMP;
    public TMP_Text[] pinsTMPTexts = new TMP_Text[3];
    public GameObject winPanel, losePanel;
    public int minPinSize = 0, maxPinSize = 10;
    public bool gameActive = true;
    public Button[] toolsButtons;

    private void SetToolsButtonsTextAndEvent() {
        if (tools.Count == toolsButtons.Length) {
            for (int i = 0; i < toolsButtons.Length; i++) {
                var indexButton = i;
                Button button = toolsButtons[indexButton];
                button.onClick.AddListener(() => OnButtonChangePin(indexButton));
                TMP_Text tmpText = button.GetComponentInChildren<TMP_Text>();
                tmpText.text = tools[indexButton].ToString();
            }
        } else {
            Debug.LogError("tools.Count != toolsButtons.Length bad!");
            gameObject.SetActive(false);
        }
    }

    private void Reset() {
        GameReset();
        List<int> tool1 = new List<int>(3) {1, -1, 0};
        tools.Add(new ToolNameAndPinsClass(){toolName = "Drill", pins = tool1});
        List<int> tool2 = new List<int>(3) {-1, 2, -1};
        tools.Add(new ToolNameAndPinsClass(){toolName = "Hammer", pins = tool2});
        List<int> tool3 = new List<int>(3) {-1, 1, -1};
        tools.Add(new ToolNameAndPinsClass(){toolName = "Latchkey", pins = tool3});
        Debug.Log("this:" + this);
    }
    private void GameReset() {
        gameActive = true;
        timerTime = timerTimeMax;
        pins = new [] { 7, 3, 5 };
        if (pinsTMPTexts.Length == pins.Length) {
            for (int p = 0; p < pinsTMPTexts.Length; p++) {
                TMP_Text tmpText = pinsTMPTexts[p];
                if (tmpText != null) {
                    tmpText.text = pins[p].ToString();
                }
            }
        } else {
            Debug.LogError("pinsTMPTexts.Length != pins.Length bad!");
            gameObject.SetActive(false);
        }
        // pinsWinRandom = new[] { Random.Range(1, 9), Random.Range(1, 9), Random.Range(1, 9) };
    }

    private void Start() {
        GameReset();
        SetToolsButtonsTextAndEvent();
        Debug.Log("this:" + this);
        // Debug.Log("pinsWinRandom:" + pinsWinRandom);
        Debug.Log("pinsWin:" + pinsWin);
    }
    private void Update() {
        if (gameActive) {
            timerTime -= Time.deltaTime;
            timerTextTMP.text = (timerTime).ToString();//"F2");
            if (timerTime < 0) {
                LoseGameAction();
                timerTextTMP.text = "Time end!";
            }
        }
    }
    public void OnButtonChangePin(int indexButton) {
        Debug.Log("OnButtonChangePin indexButton:" + indexButton);
        if (indexButton >= tools.Count) return;
        bool rightAnswer = true;
        List<int> toolPins = tools[indexButton].pins;
        for (int i = 0; i < toolPins.Count; i++) {
            pins[i] += toolPins[i];
            if (pins[i] < minPinSize || pins[i] > maxPinSize) {
                LoseGameAction();
            }
            if (pins[i] != pinsWin[i]) {
                rightAnswer = false;
            }
            pinsTMPTexts[i].text = pins[i].ToString();
        }
        if (rightAnswer) {
            WinGameAction();
        }
    }

    private void WinGameAction() {
        winPanel.SetActive(true);
        gameActive = false;
    }
    private void LoseGameAction() {
        losePanel.SetActive(true);
        gameActive = false;
    }
    public void OnButtonRestart() {
        GameReset();
        losePanel.SetActive(false);
        winPanel.SetActive(false);
    }

    public override string ToString() {
        return JsonUtility.ToJson(this);
    }
}
