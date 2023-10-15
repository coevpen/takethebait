using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{

    public void PlayGame(){

    }

    public void Settings(){
        SceneManager.LoadScene("Settings");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
