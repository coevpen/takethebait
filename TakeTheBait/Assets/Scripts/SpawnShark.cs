using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShark : MonoBehaviour
{
    [SerializeField] GameObject sharkPrefab;
    GameObject newShark;
    [SerializeField] GameObject fishingRod;
   
   
    void Update(){
        if(fishingRod.GetComponent<SpriteRenderer>().enabled == true && newShark == null){
            //SpawnSharkWhenFishing();
            newShark = Instantiate(sharkPrefab, new Vector3(3.031f,-12.91f,0), Quaternion.identity);
        }else if((fishingRod.GetComponent<SpriteRenderer>().enabled == false) && (newShark != null)){
            SharkDestroy();
        }
    }

    public void SharkDestroy(){
        // shark leaves the screen and destroys
        //once we give AI to shark, implenet if statement.
        if(newShark.transform.position.x >= 10.49 || newShark.transform.position.x <= -10.56){
            Destroy(newShark);
        }
    }
    
}
