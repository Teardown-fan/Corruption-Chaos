using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpHeight : MonoBehaviour
{
    public Button tier1;
    public Button tier2;
    public Button tier3;
    public Button tier4;
    public int jumpMultiplyer;
    public int coin;

    void Start(){
        tier1 = gameObject.transform.Find("Tier 1").GetComponent<Button>();
        tier2 = gameObject.transform.Find("Tier 2").GetComponent<Button>();
        tier3 = gameObject.transform.Find("Tier 3").GetComponent<Button>();
        tier4 = gameObject.transform.Find("Tier 4").GetComponent<Button>();
        
        tier1.onClick.AddListener(Tier1);
        tier2.onClick.AddListener(Tier2);
        tier3.onClick.AddListener(Tier3);
        tier4.onClick.AddListener(Tier4);
        jumpMultiplyer = PlayerPrefs.GetInt("jumpMultiplyer");
        coin = PlayerPrefs.GetInt("Coin");

        switch(jumpMultiplyer){
            case 1:
            tier1.interactable = false;
            break;

            case 2:
            tier2.interactable = false;
            tier1.interactable = false;
            break;

            case 3:
            tier3.interactable = false;
            tier1.interactable = false;
            tier2.interactable = false;
            break;

            case 4:
            tier4.interactable = false;
            tier1.interactable = false;
            tier2.interactable = false;
            tier3.interactable = false;
            break;
        }
    }

    void Update(){
        coin = PlayerPrefs.GetInt("Coin");
    }

    void Tier1(){
        if(jumpMultiplyer == 0 && coin >= 250){
            jumpMultiplyer = 1;
            PlayerPrefs.SetInt("jumpMultiplyer",1);
            SetCoin(250);
            tier1.interactable = false;
        }
    }

    void Tier2(){
        if(jumpMultiplyer == 1 && coin >= 500){
            jumpMultiplyer = 2;
            PlayerPrefs.SetInt("jumpMultiplyer",2);
            SetCoin(500);
            tier2.interactable = false;
        }
    }

    void Tier3(){
        if(jumpMultiplyer == 2 && coin >= 1000){
            jumpMultiplyer = 3;
            PlayerPrefs.SetInt("jumpMultiplyer",3);
            SetCoin(1000);
            tier3.interactable = false;
        }
    }

    void Tier4(){
        if(jumpMultiplyer == 3 && coin >= 1500){
            jumpMultiplyer = 4;
            PlayerPrefs.SetInt("jumpMultiplyer",4);
            SetCoin(1500);
            tier4.interactable = false;
        }
    }

    void SetCoin(int removeCoin){
        coin -= removeCoin;
        PlayerPrefs.SetInt("Coin", coin);
    }
}
