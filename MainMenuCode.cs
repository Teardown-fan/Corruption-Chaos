using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuCode : MonoBehaviour
{
    public Button levels;
    public Button evolutionTree;
    public Button quit;
    public Button reset;

    void Start(){
        levels = GameObject.Find("Levels").GetComponent<Button>();
        reset = GameObject.Find("Reset").GetComponent<Button>();
        evolutionTree = GameObject.Find("Evolution Tree").GetComponent<Button>();
        quit = GameObject.Find("Quit").GetComponent<Button>();
        levels.onClick.AddListener(LoadLevels);
        evolutionTree.onClick.AddListener(LoadEvolutionTree);
        quit.onClick.AddListener(Quit);
        reset.onClick.AddListener(Reset);
    }

    void Quit(){
        Application.Quit();
    }

    void LoadLevels(){
        SceneManager.LoadScene("Levels", LoadSceneMode.Single);
    }

    void LoadEvolutionTree(){
        SceneManager.LoadScene("Evolution Tree",LoadSceneMode.Single);
    }

    void Reset(){
        PlayerPrefs.SetInt("jumpMultiplyer", 0);
        PlayerPrefs.SetInt("Coin", 0);
        PlayerPrefs.SetInt("Lose Count", 0);
        PlayerPrefs.SetInt("Win Count", 0);
        PlayerPrefs.SetFloat("spdMultiplyer", 0);
        PlayerPrefs.SetInt("AntivirusRes", 10);

        PlayerPrefs.SetFloat("Player Width", 1);
        PlayerPrefs.SetFloat("Player Height", 1);

        PlayerPrefs.SetFloat("Item Score", 1);
        PlayerPrefs.SetFloat("Item Speed", 1);
    }
}
