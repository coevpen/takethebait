using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShark : MonoBehaviour
{
    [SerializeField] GameObject sharkPrefab;
    GameObject newShark;
    // Start is called before the first frame update
    public void Start(){
        SpawnSharkWhenFishing();
    }

    
    void SpawnSharkWhenFishing(){
        StartCoroutine(SpawnSharkWhenFishingRoutine());

        IEnumerator SpawnSharkWhenFishingRoutine(){
            // spawn shark after a set random time
            int wait_time = Random.Range(0,5);
            yield return new WaitForSeconds(wait_time);

            //make sure only one shark is around at any given time.
            newShark = Instantiate(sharkPrefab, new Vector3(Random.Range(-10.56f,10.49f),Random.Range(-17.85f,-14.8f),0), Quaternion.identity);
            yield return null;
        }
    }

    public void SharkDestroy(){
        // shark leaves the screen and destroys
        //once we give AI to shark, implenet if statement.
        // if(newShark.transform.position.x >= 10.49 || newShark.transform.position.x <= -10.56){
            Destroy(newShark);
        //}
    }
    
}
