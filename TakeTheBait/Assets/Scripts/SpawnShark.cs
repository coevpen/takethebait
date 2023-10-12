using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShark : MonoBehaviour
{
    [SerializeField] GameObject sharkPrefab;
    // Start is called before the first frame update
    void Start(){
        SpawnSharkWhenFishing();
    }

    
    void SpawnSharkWhenFishing(){
        StartCoroutine(SpawnSharkWhenFishingRoutine());

        IEnumerator SpawnSharkWhenFishingRoutine(){
            // spawn shark after a set random time
            //make sure only one shark is around at any given time.

            // }

            yield return null;
        }
    }
}
