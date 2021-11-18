using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemScore : MonoBehaviour
{
    public Button tier1;
    public Button tier2;
    public Button tier3;
    public Button tier4;
    public float itemScore;
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
        itemScore = PlayerPrefs.GetFloat("Item Score");

        switch(itemScore){
            case 1.5f:
            tier1.interactable = false;
            break;

            case 2:
            tier2.interactable = false;
            tier1.interactable = false;
            break;

            case 2.5f:
            tier3.interactable = false;
            tier1.interactable = false;
            tier2.interactable = false;
            break;

            case 3:
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
        if(itemScore == 1 && coin >= 250){
            itemScore = 1.5f;
            PlayerPrefs.SetFloat("Item Score",1.5f);
            SetCoin(750);
            tier1.interactable = false;
        }
    }

    void Tier2(){
        if(itemScore == 1.5f && coin >= 500){
            itemScore = 2;
            PlayerPrefs.SetFloat("Item Score",2);
            SetCoin(1500);
            tier2.interactable = false;
        }
    }

    void Tier3(){
        if(itemScore == 2 && coin >= 1000){
            itemScore = 2.5f;
            PlayerPrefs.SetFloat("Item Score",2.5f);
            SetCoin(2250);
            tier3.interactable = false;
        }
    }

    void Tier4(){
        if(itemScore == 2.5f && coin >= 1500){
            itemScore = 3;
            PlayerPrefs.SetFloat("Item Score ",3);
            SetCoin(3000);
            tier4.interactable = false;
        }
    }

    void SetCoin(int removeCoin){
        coin -= removeCoin;
        PlayerPrefs.SetInt("Coin", coin);
    }
}
