using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishingMechanic : MonoBehaviour
{
    Score playerScore;
    GameObject Canvas;
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
                fishingRod.GetComponent<SpriteRenderer>().enabled = true;
                playerScore.ScoreIncrease();
                yield return new WaitForSeconds(1);
                fishingRod.GetComponent<SpriteRenderer>().enabled = false;
            }

            yield return null;
        }
    }
}
