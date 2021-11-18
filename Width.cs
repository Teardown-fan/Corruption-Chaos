using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Width : MonoBehaviour
{
    public Button tier1;
    public Button tier2;
    public Button tier3;
    public Button tier4;
    public float width;
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
        width = PlayerPrefs.GetFloat("Player Width");

        switch(width){
            case 1.2f:
            tier1.interactable = false;
            break;

            case 1.4f:
            tier2.interactable = false;
            tier1.interactable = false;
            break;

            case 1.6f:
            tier3.interactable = false;
            tier1.interactable = false;
            tier2.interactable = false;
            break;

            case 1.8f:
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
        if(width == 1 && coin >= 750){
            width = 1.2f;
            PlayerPrefs.SetFloat("Player Width",1.2f);
            SetCoin(750);
            tier1.interactable = false;
        }
    }

    void Tier2(){
        if(width == 1.2f && coin >= 1500){
            width = 1.4f;
            PlayerPrefs.SetFloat("Player Width",1.4f);
            SetCoin(1500);
            tier2.interactable = false;
        }
    }

    void Tier3(){
        if(width == 1.4f && coin >= 2250){
            width = 1.6f;
            PlayerPrefs.SetFloat("Player Width",1.6f);
            SetCoin(2250);
            tier3.interactable = false;
        }
    }

    void Tier4(){
        if(width == 1.6f && coin >= 3000){
            width = 1.8f;
            PlayerPrefs.SetFloat("Player Width",1.8f);
            SetCoin(3000);
            tier4.interactable = false;
        }
    }
    
    void SetCoin(int removeCoin){
        coin -= removeCoin;
        PlayerPrefs.SetInt("Coin", coin);
    }
}
