using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    public Button tier1;
    public Button tier2;
    public Button tier3;
    public Button tier4;
    public float spdMultiplyer;
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
        spdMultiplyer = PlayerPrefs.GetFloat("spdMultiplyer");

        switch(spdMultiplyer){
            case 0.5f:
            tier1.interactable = false;
            break;

            case 1:
            tier2.interactable = false;
            tier1.interactable = false;
            break;

            case 1.5f:
            tier3.interactable = false;
            tier1.interactable = false;
            tier2.interactable = false;
            break;

            case 2:
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
        if(spdMultiplyer == 0 && coin >= 250){
            spdMultiplyer = 0.5f;
            PlayerPrefs.SetFloat("spdMultiplyer",0.5f);
            SetCoin(250);
            tier1.interactable = false;
        }
    }

    void Tier2(){
        if(spdMultiplyer == 0.5f && coin >= 500){
            spdMultiplyer = 1;
            PlayerPrefs.SetFloat("spdMultiplyer",1);
            SetCoin(500);
            tier2.interactable = false;
        }
    }

    void Tier3(){
        if(spdMultiplyer == 1 && coin >= 1000){
            spdMultiplyer = 1.5f;
            PlayerPrefs.SetFloat("spdMultiplyer",1.5f);
            SetCoin(1000);
            tier3.interactable = false;
        }
    }

    void Tier4(){
        if(spdMultiplyer == 1.5f && coin >= 1500){
            spdMultiplyer = 2;
            PlayerPrefs.SetFloat("spdMultiplyer",2);
            SetCoin(1500);
            tier4.interactable = false;
        }
    }

    void SetCoin(int removeCoin){
        coin -= removeCoin;
        PlayerPrefs.SetInt("Coin", coin);
    }
}
