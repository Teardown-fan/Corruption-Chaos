using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TechTreeCore : MonoBehaviour
{
    public Button back;
    public Text coin;

    void Start(){
        back = GameObject.Find("Back").GetComponent<Button>();
        coin = GameObject.Find("Coin").GetComponent<Text>();
        back.onClick.AddListener(LoadStart);
    }

    void Update(){
        coin.text = "Coin:" + PlayerPrefs.GetInt("Coin");
    }

    void LoadStart(){
        SceneManager.LoadScene("Main Menu Screen", LoadSceneMode.Single);
    }
}
