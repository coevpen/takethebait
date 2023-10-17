using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SFXVolumeManager : MonoBehaviour
{
    [SerializeField] Slider SFXSlider;
    [SerializeField] Slider musicSlider;
    [SerializeField] AudioMixer mixer;

    const string MIXER_MUSIC = "MusicVol";
    const string MIXER_SFX = "SFXVol";

    void Awake(){
        musicSlider.onValueChanged.AddListener(ChangeMusicVolume);
        SFXSlider.onValueChanged.AddListener(ChangeSFXVolume);
    }

    void ChangeMusicVolume(float value){
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value) * 20);
    }

    void ChangeSFXVolume(float value){
        mixer.SetFloat(MIXER_SFX, Mathf.Log10(value) * 20);
    }
}


