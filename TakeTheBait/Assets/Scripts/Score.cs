using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    //Text scoreTxt;
    public TMPro.TextMeshProUGUI scoreTxt;
    public TMPro.TextMeshProUGUI hiScoreTxt;
    int scoreCount = 0;
    int highScore = 0;
    int newScore = 0;

    void Awake(){
        hiScoreTxt = GetComponent<TextMeshProUGUI>();
        if(PlayerPrefs.HasKey("currentScore")){
            newScore = PlayerPrefs.GetInt("currentScore");
        }
        if(PlayerPrefs.HasKey("hiScore")){
            if(newScore > PlayerPrefs.GetInt("hiScore")){
                highScore = newScore;
                PlayerPrefs.SetInt("hiScore", highScore);
                PlayerPrefs.Save();
            }
        }else{   
            if(newScore > highScore){
                highScore = newScore;
                PlayerPrefs.SetInt("hiScore", highScore);
                PlayerPrefs.Save();
            }
        }
               
    }

    void Start(){
        scoreTxt = GetComponent<TextMeshProUGUI>();
        hiScoreTxt.text = PlayerPrefs.GetInt("hiScore",0).ToString();
    }

    public void ScoreIncrease(int val){
        scoreCount += val;
        scoreTxt.text = scoreCount.ToString();
        PlayerPrefs.SetInt("currentScore", scoreCount);
        PlayerPrefs.Save();
    }



}
