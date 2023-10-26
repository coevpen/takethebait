using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{

    public void PlayGame(){
        SceneManager.LoadScene("ChooseScene");
    }

    // public void Beach(){
    //     SceneManager.LoadScene("FishingScene");
    // }
    // public void Forest(){
    //     SceneManager.LoadScene("ForestScene");
    // }

    // public void Cave(){
    //     SceneManager.LoadScene("CaveScene");
    // }

    public void Settings(){
        SceneManager.LoadScene("Settings");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
