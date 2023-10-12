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

    public void ScoreIncrease(){
        scoreCount += 1;
        scoreTxt.text = scoreCount.ToString();
    }

}
