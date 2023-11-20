using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreReset : MonoBehaviour
{
    public TMPro.TextMeshProUGUI highScoreTxt;
    GameObject canvas;
    GameObject hiscore;

    void Awake(){
        canvas = GameObject.Find("Canvas");
        hiscore = canvas.transform.GetChild(1).gameObject;
        highScoreTxt = hiscore.GetComponent<TextMeshProUGUI>();
    }

    void Start(){
        highScoreTxt.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void Reset(){
        PlayerPrefs.DeleteKey("HighScore");
        highScoreTxt.text = "0";
    }
}
