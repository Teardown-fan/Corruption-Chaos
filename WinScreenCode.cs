using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScreenCode : MonoBehaviour
{
    public Button mainMenu;
    public Button evolutionTree;

    void Start(){
        PlayerPrefs.SetInt("Win Count", PlayerPrefs.GetInt("Win Count") + 1);
        mainMenu = GameObject.Find("Main Menu").GetComponent<Button>();
        evolutionTree = GameObject.Find("Evolution Tree").GetComponent<Button>();
        mainMenu.onClick.AddListener(LoadMainMenu);
        evolutionTree.onClick.AddListener(LoadEvolutionTree);
    }

    void LoadMainMenu(){
        SceneManager.LoadScene("Main Menu Screen",LoadSceneMode.Single);
    }

    void LoadEvolutionTree(){
        SceneManager.LoadScene("Evolution Tree",LoadSceneMode.Single);
    }
}
