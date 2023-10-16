using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SharkMovement : MonoBehaviour
{
    [SerializeField] float speed = 0.3f;
    GameObject MainChar;
    GameObject  fishingRod;

    void Awake(){
        MainChar = GameObject.Find("MainChar");
        fishingRod = MainChar.transform.GetChild(1).gameObject;
    }

    void Update()
    {
        //if the rod is in the water, the shark moves towards it
        if(fishingRod.GetComponent<SpriteRenderer>().enabled == true){
            transform.position = Vector3.MoveTowards(fishingRod.transform.position,transform.position,speed * Time.deltaTime);
        }
        else{//otherwise the shark swims off to the left of the screen
           transform.position += new Vector3(speed * Time.deltaTime,0,0);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        //if shark touches fishing rod, game over
        SceneManager.LoadScene("MainMenu");
    }
}
