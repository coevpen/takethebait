using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SharkMovement : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;
    bool rodOut;
        // have shark hone in on fishing rod
        // if shark touches fishing rod before it is removed, game over
        // if shark does not catch it in time, have shark path find to left of screen and destroy itself

    void Awake(){

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed,0,0);

    }

    void OnTriggerEnter2D(Collider2D other){
         //if shark touches fishing rod

         SceneManager.LoadScene("Menu");
    }
}
