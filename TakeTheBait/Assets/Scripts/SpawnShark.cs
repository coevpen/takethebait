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
    public bool sharkExists = false;

    void Awake(){
        player = MainChar.GetComponent<PlayerInput>();
    }
   
   
    void Update(){
        if(player.rodOut && !sharkExists){
            Invoke("SpawnSharkRandom",Random.Range(3,15));
        }
    }

    void SpawnSharkRandom(){
        StartCoroutine(SpawnSharkRandomCoR());
        IEnumerator SpawnSharkRandomCoR(){
            if(player.rodOut && !sharkExists){
                newShark = Instantiate(sharkPrefab, new Vector3(Random.Range(16.19f,-22.34f),Random.Range(-13.37f,-19.15f),0), Quaternion.identity);
                sharkExists = true;
            }
            if(!player.rodOut && sharkExists){
                SharkDestroy();
            }
            yield return null;
        }
    }


    public void SharkDestroy(){
        // shark leaves the screen and destroys   10.49
        if(sharkExists && newShark.transform.position.x >= 16.19 || newShark.transform.position.x <= -22.34){
            Destroy(newShark);
            sharkExists = false;
        }
    }
    
}
