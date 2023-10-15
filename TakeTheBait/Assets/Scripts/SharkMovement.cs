using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SharkMovement : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    GameObject MainChar;
    GameObject  fishingRod;
    //bool rodOut = true;
        // have shark hone in on fishing rod
        // if shark touches fishing rod before it is removed, game over
        // if shark does not catch it in time, have shark path find to left of screen and destroy itself

    void Awake(){
        MainChar = GameObject.Find("MainChar");
        fishingRod = MainChar.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(fishingRod.GetComponent<SpriteRenderer>().enabled == true){
            transform.position = Vector3.MoveTowards(transform.position,fishingRod.transform.position,speed * Time.deltaTime);
        }
        else{
           transform.position += new Vector3(speed,0,0);
        }

    }

    void OnTriggerEnter2D(Collider2D other){
        //if shark touches fishing rod

        SceneManager.LoadScene("MainMenu");
    }
}
