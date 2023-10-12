using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject fishingRod;
    [SerializeField] fishingMechanic fishingStart;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if((player.transform.position.y < -10.59042) & Input.GetKey(KeyCode.E)){
            fishingRod.GetComponent<SpriteRenderer>().enabled = true;
            fishingStart.Start();
        }
    }
}
