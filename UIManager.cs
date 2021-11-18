using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public WinLose loseScript;
    public float score = 0;
    public float negScore = 0;
    public float winScore = 100;
    public float loseScore = 50;
    public bool lost = false;
    public bool won = false;
    public GameObject menu;
    public bool paused = false;
    public GameObject menuObj;
    public int winCoinCount = 1000;

    void Start(){
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        loseScript = GameObject.Find("Win").GetComponent<WinLose>();
    }

    void Update(){
        score = loseScript.score;
        negScore = loseScript.negScore;
        
        if(negScore <= -loseScore){
            lost = true;
            Lose();
        }
        if(score >= winScore){
            won = true;
            Win();
        }
        if(lost){
            Lose();
        }
        if(won){
            Win();
        }
        scoreText.text = "<" + score + "/" + winScore + ">";
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(paused == false){
                Vector3 pos = new Vector3(0,0,0);
                Quaternion rot = new Quaternion(0,0,0,0);
                menuObj = Instantiate(menu, pos, rot);
                paused = true;
            } else if(menuObj != null){
                paused = false;
                Destroy(menuObj);
            }
        }
    }

    void Win(){
        SceneManager.LoadScene("Won Screen", LoadSceneMode.Single);
        PlayerPrefs.SetInt("Coin", PlayerPrefs.GetInt("Coin") + winCoinCount);
    }

    void Lose(){
        SceneManager.LoadScene("Lose Screen", LoadSceneMode.Single);
    }
}
