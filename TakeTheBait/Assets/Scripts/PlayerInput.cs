using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject fishingRod;
    Score playerScore;
    GameObject Canvas;
    GameObject pauseLabel;
    GameObject MainChar;
    GameObject exclaim;
    GameObject pmenu;
    public bool rodOut = false;
    bool isPaused = false;
    float previousTimeScale;
    bool fish = false;
    string fishSize;

    //for fishing game
    int upperBound = 0;
    int lowerBound = 17;
    int points = 0;

    void Awake(){
        Canvas = GameObject.Find("Canvas");
        playerScore = Canvas.GetComponentInChildren<Score>();
        MainChar = GameObject.Find("MainChar");
        exclaim = MainChar.transform.GetChild(2).gameObject;
        pmenu = GameObject.Find("QuitOption");
        pmenu.SetActive(false);
    }

    // Update is called once per frame
    void Update(){
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
            pmenu.SetActive(true);
            isPaused = true;
        }else if(Time.timeScale == 0){
            Time.timeScale = previousTimeScale;
            AudioListener.pause = false;
            pmenu.SetActive(false);
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

                    yield return new WaitForSeconds(Random.Range(3,12));
                    fish = false;
                    int randFish = Random.Range(lowerBound,upperBound);
                    if(randFish >= 0 && randFish <=10){
                        points = 1;
                        fishSize = "small";
                    }else if(randFish >= 11 && randFish <= 15){
                        points = 2;
                        fishSize = "medium";
                    }else if(randFish >= 16 && randFish <= 17){
                        points = 4;
                        fishSize = "large";
                    }
                    fish = true;
                    if(fish && rodOut){
                        exclaim.GetComponent<SpriteRenderer>().enabled = true;
                    }
                    
                }else{
                    if(!isPaused){
                        rodOut = false;
                        if(fish && !rodOut){
                            playerScore.ScoreIncrease(points);
                        }
                        if(!rodOut){
                            fishingRod.GetComponent<SpriteRenderer>().enabled = false;
                            exclaim.GetComponent<SpriteRenderer>().enabled = false;
                        }
                        fish = false;
                        
                    }

                }

            }

            yield return null;
        }
    }
}
