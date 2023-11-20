using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    //Text scoreTxt;
    public TMPro.TextMeshProUGUI scoreTxt;
    public TMPro.TextMeshProUGUI highScoreTxt;
    GameObject canvas;
    GameObject score;
    GameObject hiscore;
    int scoreCount = 0;

    void Awake(){
        //scoreTxt = GetComponent<TextMeshProUGUI>();
        canvas = GameObject.Find("Canvas");
        score = canvas.transform.GetChild(1).gameObject;
        hiscore = canvas.transform.GetChild(3).gameObject;
        scoreTxt = score.GetComponent<TextMeshProUGUI>();
        highScoreTxt = hiscore.GetComponent<TextMeshProUGUI>();
    }

    void Start(){
        highScoreTxt.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void ScoreIncrease(int val){
        scoreCount += val;
        scoreTxt.text = scoreCount.ToString();

        if(scoreCount > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", scoreCount);
            highScoreTxt.text = scoreCount.ToString();
        }
        
    }

    public void Reset(){
        PlayerPrefs.DeleteKey("HighScore");
        highScoreTxt.text = "0";
    }

}
