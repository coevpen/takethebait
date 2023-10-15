using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMusic : MonoBehaviour
{
    public static MenuMusic instance;

    // audio clips
    private AudioSource audioSource;
    public AudioClip MenuSong;
    public AudioClip beachSong;

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
            lastScene = currentScene;
            songChange();
        }
    }


    void songChange(){

        if(lastScene == "MainMenu" || lastScene == "Settings"){
            //audioSource.PlayOneShot(MenuSong, 0.5f);
            audioSource.GetComponent<AudioSource>().Play();
        }
        else if(lastScene == "FishingScene"){
            audioSource.Stop();
            //audioSource.PlayOneShot(beachSong);
        }

    }

}
