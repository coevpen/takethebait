using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovementController : MonoBehaviour
{
    [SerializeField] Movement movement;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
