using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject fishingRod;
    Score playerScore;
    GameObject Canvas;
    GameObject pauseLabel;
    public bool rodOut = false;
    bool isPaused = false;
    float previousTimeScale;

    void Awake(){
        Canvas = GameObject.Find("Canvas");
        pauseLabel = Canvas.transform.GetChild(2).gameObject;
        playerScore = Canvas.GetComponentInChildren<Score>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if((player.transform.position.y < -10.32)){
            fishingGameStart();
        }
        //if the player presses escape, the game pauses.
        if(Input.GetKeyDown(KeyCode.Q)){
            TogglePause();
        }

    }

    void TogglePause(){
        if(Time.timeScale > 0){
            previousTimeScale = Time.timeScale;
            Time.timeScale = 0;
            AudioListener.pause = true;
            pauseLabel.GetComponent<Text>().enabled = true;
            isPaused = true;
        }else if(Time.timeScale == 0){
            Time.timeScale = previousTimeScale;
            AudioListener.pause = false;
            pauseLabel.GetComponent<Text>().enabled = false;
            isPaused = false;
        }
    }

    public void fishingGameStart(){
        StartCoroutine(fishingGameStartRoutine());

        IEnumerator fishingGameStartRoutine(){
            if(Input.GetKeyDown(KeyCode.E) && !isPaused){
                if(rodOut == false){
                    rodOut = true;
                    fishingRod.GetComponent<SpriteRenderer>().enabled = true;
                    fishingRod.GetComponent<AudioSource>().Play();
                }else{
                    if(!isPaused){
                        rodOut = false;
                        playerScore.ScoreIncrease();
                        fishingRod.GetComponent<SpriteRenderer>().enabled = false;
                    }

                }

            }

            yield return null;
        }
    }
}
