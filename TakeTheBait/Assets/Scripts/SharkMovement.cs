using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SharkMovement : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    public GameObject MainChar;
    public PlayerInput player;
    GameObject fishingRod;


    void Awake(){
        MainChar = GameObject.Find("MainChar");
        fishingRod = MainChar.transform.GetChild(1).gameObject;
        player = MainChar.GetComponent<PlayerInput>();
    }

    void Update(){
        //if the rod is in the water, the shark moves towards it
        if(player.rodOut){
            Vector3 vel = Vector3.Normalize(fishingRod.transform.position - transform.position);
            transform.position += (vel * speed * Time.deltaTime) * 20;
            if(vel.x > 0){
                transform.localScale = new Vector3(-1,1,1);
            }else if(vel.x < 0){
                transform.localScale = new Vector3(1,1,1);
            }
        }
        else{//otherwise the shark swims off to the side of the screen
            transform.position += new Vector3((speed * Time.deltaTime) * 20,0,0);
            if(transform.position.x > 0){
                transform.localScale = new Vector3(-1,1,1);
            }else if(transform.position.x < 0){
                transform.localScale = new Vector3(1,1,1);
            }

        }
    }

    void OnTriggerEnter2D(Collider2D other){
        //if shark touches fishing rod, game over
        SceneManager.LoadScene("MainMenu");
    }
}
