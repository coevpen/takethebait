using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToggleOptions : MonoBehaviour
{
    Toggle vysncToggle, fullScreenToggle;

    public List<Rez> resolutions = new List<Rez>();
    private int selectedRez;
    public TMP_Text rezLabel;


    void Start(){
        vysncToggle = GameObject.Find("VsyncToggle").GetComponent<Toggle>();  
        fullScreenToggle = GameObject.Find("ScreenToggle").GetComponent<Toggle>();

        bool foundRes = false;
        for(int i = 0; i < resolutions.Count; i++){
            if(Screen.width == resolutions[i].horizontal && Screen.height == resolutions[i].vertical){
                foundRes = true;

                selectedRez = i;

                updateRezLabel();
            }
        }

        if(!foundRes){
            Rez newRez = new Rez();
            newRez.horizontal = Screen.width;
            newRez.vertical = Screen.height;

            resolutions.Add(newRez);
            selectedRez = resolutions.Count - 1;

            updateRezLabel();
        }
    }

    public void ToggleScreen(){
        fullScreenToggle.isOn = Screen.fullScreen;
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

    public void RezLeft(){
        selectedRez--;
        if(selectedRez < 0){
            selectedRez = 0;
        }
        updateRezLabel();
    }

    public void RezRight(){
        selectedRez++;
        if(selectedRez > resolutions.Count - 1){
            selectedRez = resolutions.Count - 1;
        }
        updateRezLabel();
    }

    public void updateRezLabel(){
        rezLabel.text = resolutions[selectedRez].horizontal.ToString() + " X " + resolutions[selectedRez].vertical.ToString();
    }

    public void ApplyResolution(){
        Screen.SetResolution(resolutions[selectedRez].horizontal,resolutions[selectedRez].vertical,fullScreenToggle.isOn);
    }

    [System.Serializable]
    public class Rez{
        public int horizontal, vertical;
    }
}

