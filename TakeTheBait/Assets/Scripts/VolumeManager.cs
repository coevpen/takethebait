using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    

    void Start(){
        if(!PlayerPrefs.HasKey("masterVolume")){
            PlayerPrefs.SetFloat("masterVolume", Mathf.Log10(volumeSlider.value) * 20);
            LoadPrefs();
        }
    }

    public void ChangeVolume(){
        AudioListener.volume = volumeSlider.value;
        SavePrefs();
    }

    public void LoadPrefs(){
        volumeSlider.value = PlayerPrefs.GetFloat("masterVolume");
    }

    public void SavePrefs(){
        PlayerPrefs.SetFloat("masterVolume", volumeSlider.value);
    }
}
