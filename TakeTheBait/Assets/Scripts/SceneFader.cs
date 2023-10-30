using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    [SerializeField] Image fadeImage;
    [SerializeField] float fadeTime = 3;

    void Awake(){
        FadeIn();
    }

    void Start(){
        Time.timeScale = 1f;
    }

    public void FadeIn(){
        StartCoroutine(FadeInRoutine());
        IEnumerator FadeInRoutine(){
            float timer = 0;
            while(timer < fadeTime){
                fadeImage.color = new Color(0,0,0,1f-(timer/fadeTime));
                timer+=Time.deltaTime;
                yield return null;
            }
            fadeImage.color = Color.clear;
            yield return null;
        }
    }
    
    public void FadeOut(string sceneName){
        StartCoroutine(FadeOutRoutine());
        IEnumerator FadeOutRoutine(){
            float timer = 0;
            while(timer < fadeTime){
                fadeImage.color = new Color(0,0,0,(timer/fadeTime));
                timer+=Time.deltaTime;
                yield return null;
            }
            fadeImage.color = Color.black;
            yield return null;
            SceneManager.LoadScene(sceneName);
        }
    }
}
