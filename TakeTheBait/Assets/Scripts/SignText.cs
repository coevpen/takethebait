using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SignText : MonoBehaviour
{
    [SerializeField] private GameObject MainChar;
    [SerializeField] private GameObject signPrefab;
    [SerializeField] private GameObject TextBox;
    [SerializeField] private GameObject Ttext;
    [SerializeField] private GameObject TtextButton1;
    [SerializeField] private GameObject TtextButton2;

    void Awake(){
        TextBox.GetComponent<SpriteRenderer>().enabled = false;
        Ttext.GetComponent<TextMeshProUGUI>().enabled = false;
        TtextButton1.GetComponent<TextMeshProUGUI>().enabled = false;
        TtextButton2.GetComponent<TextMeshProUGUI>().enabled = false;
    }
    
    void OnTriggerEnter2D(Collider2D other){
        TextBox.GetComponent<SpriteRenderer>().enabled = true;
        Ttext.GetComponent<TextMeshProUGUI>().enabled = true;
        TtextButton1.GetComponent<TextMeshProUGUI>().enabled = true;
        TtextButton2.GetComponent<TextMeshProUGUI>().enabled = true;
    }

    void OnTriggerExit2D(Collider2D other) {
        TextBox.GetComponent<SpriteRenderer>().enabled = false;
        Ttext.GetComponent<TextMeshProUGUI>().enabled = false;
        TtextButton1.GetComponent<TextMeshProUGUI>().enabled = false;
        TtextButton2.GetComponent<TextMeshProUGUI>().enabled = false;
    }
}
