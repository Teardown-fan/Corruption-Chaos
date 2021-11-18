using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Button tutorial;
    public Button lvl1;
    public Button lvl2;
    public Button lvl3;
    public Button lvl4;
    public Button lvl5;
    public Button back;
    public Text loseWin;

    void Start(){
        loseWin = GameObject.Find("Win/Lose").GetComponent<Text>();
        loseWin.text = "<" + MinDivisible(PlayerPrefs.GetInt("Win Count"),PlayerPrefs.GetInt("Lose Count")) + "/" + MinDivisible(PlayerPrefs.GetInt("Lose Count"),PlayerPrefs.GetInt("Win Count")) + ">";
        back = GameObject.Find("Back").GetComponent<Button>();
        back.onClick.AddListener(LoadMenu);
        lvl1 = GameObject.Find("Level 1").GetComponent<Button>();
        lvl1.onClick.AddListener(LoadLevel1);
        lvl2 = GameObject.Find("Level 2").GetComponent<Button>();
        lvl2.onClick.AddListener(LoadLevel2);
        lvl3 = GameObject.Find("Level 3").GetComponent<Button>();
        lvl3.onClick.AddListener(LoadLevel3);
        lvl4 = GameObject.Find("Level 4").GetComponent<Button>();
        lvl4.onClick.AddListener(LoadLevel4);
        lvl5 = GameObject.Find("Level 5").GetComponent<Button>();
        lvl5.onClick.AddListener(LoadLevel5);
        tutorial = GameObject.Find("Tutorial").GetComponent<Button>();
        tutorial.onClick.AddListener(LoadTutorial);
    }
    #region LevelLoaders
    void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }

    void LoadLevel4()
    {
        SceneManager.LoadScene("Level 4");
    }

    void LoadLevel5()
    {
        SceneManager.LoadScene("Level 5");
    }

    void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    void LoadMenu(){
        SceneManager.LoadScene("Main Menu Screen", LoadSceneMode.Single);
    }
    #endregion LevelLoaders

    float MinDivisible(float a, float b){
        if(a/b == Mathf.Floor(a/b)){
            return a/b;
        }
        return a;
    }
}
