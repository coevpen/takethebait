using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishingMechanic : MonoBehaviour
{
    Score playerScore;
    GameObject Canvas;
    bool rodOut = false;
    [SerializeField] GameObject fishingRod;
    void Awake(){
        Canvas = GameObject.Find("Canvas");
        playerScore = Canvas.GetComponentInChildren<Score>();
    }
    
    // Start is called before the first frame update
    public void Start()
    {
       fishingGameStart();

    }

    public void fishingGameStart(){
        StartCoroutine(fishingGameStartRoutine());

        IEnumerator fishingGameStartRoutine(){
            if(Input.GetKeyDown(KeyCode.E)){
                if(rodOut == false){
                    rodOut = true;
                    fishingRod.GetComponent<SpriteRenderer>().enabled = true;
                }else{
                    rodOut = false;
                    playerScore.ScoreIncrease();
                    fishingRod.GetComponent<SpriteRenderer>().enabled = false;
                }

            }

            yield return null;
        }
    }
}
