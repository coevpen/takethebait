using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject fishingRod;
    Score playerScore;
    GameObject Canvas;
    bool rodOut = false;

    void Awake(){
        Canvas = GameObject.Find("Canvas");
        playerScore = Canvas.GetComponentInChildren<Score>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if((player.transform.position.y < -10.59042)){

            fishingGameStart();
        }

    }

    public void fishingGameStart(){
        StartCoroutine(fishingGameStartRoutine());

        IEnumerator fishingGameStartRoutine(){
            if(Input.GetKeyDown(KeyCode.E)){
                if(rodOut == false){
                    rodOut = true;
                    fishingRod.GetComponent<SpriteRenderer>().enabled = true;
                    fishingRod.GetComponent<AudioSource>().Play();
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
