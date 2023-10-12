using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkMovement : MonoBehaviour
{
        // have shark hone in on fishing rod
        // if shark touches fishing rod before it is removed, game over
        // if shark does not catch it in time, have shark path find to left of screen and destroy itself

            // Update is called once per frame
    void Update()
    {
        //transform position to hone in on fishing rod
    }

    void OnTriggerEnter2D(Collider2D other){
        //if shark touches fishing rod
        //SceneManager.LoadScene("Menu");  or make a game over screen
    }
}
