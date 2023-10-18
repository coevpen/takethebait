using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovementController : MonoBehaviour
{
    [SerializeField] Movement movement;
    // to get rodOut bool
    GameObject MainChar;
    public PlayerInput player;

    void Awake(){
        MainChar = GameObject.Find("MainChar");
        player = MainChar.GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update(){
        // disables movement if the player's fishing rod is out
        if(!player.rodOut){
            Vector3 vel = Vector3.zero;
            if(Input.GetKey(KeyCode.W)){
                vel.y = 1;
            }else if(Input.GetKey(KeyCode.S)){
                vel.y = -1;
            }else if(Input.GetKey(KeyCode.A)){
                vel.x = -1;
            }else if(Input.GetKey(KeyCode.D)){
                vel.x = 1;
            }
            
            movement.MoveTransform(vel);
        }
    }
}
