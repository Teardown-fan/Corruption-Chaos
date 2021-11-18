using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Button continue1;
    public Button mainMenu;
    public UIManager uiScript;

    void Start(){
        continue1 = GameObject.Find("Continue").GetComponent<Button>();
        mainMenu = GameObject.Find("Main Menu").GetComponent<Button>();
        continue1.onClick.AddListener(Unload);
        mainMenu.onClick.AddListener(LoadMainMenu);
        uiScript = GameObject.Find("Managers").GetComponent<UIManager>();
    }

    void Unload(){
        uiScript.paused = false;
        Destroy(gameObject);
    }

    void LoadMainMenu(){
        uiScript.paused = false;
        SceneManager.LoadScene("Main Menu Screen", LoadSceneMode.Single);
    }
}
