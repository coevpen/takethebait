using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShark : MonoBehaviour
{
    [SerializeField] public GameObject sharkPrefab;
    GameObject newShark;
    // to get the user's rodOut bool
    public PlayerInput player;
    public GameObject MainChar;

    void Awake(){
        player = MainChar.GetComponent<PlayerInput>();
    }
   
   
    void Update(){
        if(player.rodOut && newShark == null){
            newShark = Instantiate(sharkPrefab, new Vector3(3.031f,-12.91f,0), Quaternion.identity);
        }else if(!player.rodOut && (newShark != null)){
            SharkDestroy();
        }
    }

    public void SharkDestroy(){
        // shark leaves the screen and destroys
        if(newShark.transform.position.x >= 10.49 || newShark.transform.position.x <= -10.56){
            Destroy(newShark);
        }
    }
    
}
