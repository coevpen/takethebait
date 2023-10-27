using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    //Text scoreTxt;
    public TMPro.TextMeshProUGUI scoreTxt;
    int scoreCount = 0;

    void Start(){
        scoreTxt = GetComponent<TextMeshProUGUI>();
    }

    public void ScoreIncrease(int val){
        scoreCount += val;
        scoreTxt.text = scoreCount.ToString();
    }

}
