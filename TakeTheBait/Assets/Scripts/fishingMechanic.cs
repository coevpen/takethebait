using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishingMechanic : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void Start()
    {
       fishingGameStart();
    }

    public void fishingGameStart(){
        Debug.Log("Fishing!");
        StartCoroutine(fishingGameStartRoutine());

        IEnumerator fishingGameStartRoutine(){
            yield return null;
        }
    }
}
