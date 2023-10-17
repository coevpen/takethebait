using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleOptions : MonoBehaviour
{
    Toggle vysncToggle;

    void Start(){
        vysncToggle = GameObject.Find("VsyncToggle").GetComponent<Toggle>();  
    }

    public void ToggleScreen(){
        Screen.fullScreen = !Screen.fullScreen;
    }
    
    public void VsyncToggle(){
        if(vysncToggle.isOn){
            QualitySettings.vSyncCount = 1;
            Debug.Log("Vysnc change");
        }else{
            QualitySettings.vSyncCount = 0;
            Debug.Log("Vysnc  change");
        }
    }
}
