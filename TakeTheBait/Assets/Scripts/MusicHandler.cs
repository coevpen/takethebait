using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMusic : MonoBehaviour
{
    public static MenuMusic instance;

    // audio clips
    private AudioSource audioSource;

    // checking for scene loaded
    private string lastScene;
    private string currentScene;


    void Awake(){
        if(instance != null){
            Destroy(gameObject);
        }else{
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        audioSource = GetComponent<AudioSource>();
        lastScene = SceneManager.GetActiveScene().name;

        if(!PlayerPrefs.HasKey ("Game Start")) { 
            PlayerPrefs.SetInt("Game Start", 123);
        }
    }

    void Update(){
        currentScene = SceneManager.GetActiveScene().name;
        if(currentScene != lastScene){
            songChange();
        }
    }


    void songChange(){

        if((lastScene == "MainMenu" || lastScene == "Settings") && (currentScene == "MainMenu" || currentScene == "Settings")){
            lastScene = currentScene;
        }
        else if(lastScene == "MainMenu" && currentScene == "FishingScene"){
            audioSource.Stop();
            lastScene = currentScene;
        }
        else if(lastScene == "FishingScene" && currentScene == "MainMenu"){
            audioSource.Stop();
            audioSource.GetComponent<AudioSource>().Play();
            lastScene = currentScene;
        }

    }

}
