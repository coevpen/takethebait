using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreTxt;
    int scoreCount = 0;

    void Start(){
        scoreTxt = GetComponent<Text>();
    }

    public void ScoreIncrease(int val){
        scoreCount += val;
        scoreTxt.text = scoreCount.ToString();
    }

}
