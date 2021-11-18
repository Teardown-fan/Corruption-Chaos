using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSpeed : MonoBehaviour
{
    public Button tier1;
    public Button tier2;
    public Button tier3;
    public Button tier4;
    public float itemSpeed;
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
        itemSpeed = PlayerPrefs.GetFloat("Item Speed");

        switch(itemSpeed){
            case 0.9f:
            tier1.interactable = false;
            break;

            case 0.8f:
            tier2.interactable = false;
            tier1.interactable = false;
            break;

            case 0.7f:
            tier3.interactable = false;
            tier1.interactable = false;
            tier2.interactable = false;
            break;

            case 0.6f:
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
        if(itemSpeed == 1 && coin >= 750){
            itemSpeed = 0.9f;
            PlayerPrefs.SetFloat("Item Speed",0.9f);
            SetCoin(750);
            tier1.interactable = false;
        }
    }

    void Tier2(){
        if(itemSpeed == 0.9f && coin >= 1500){
            itemSpeed = 0.8f;
            PlayerPrefs.SetFloat("Item Speed",0.8f);
            SetCoin(1500);
            tier2.interactable = false;
        }
    }

    void Tier3(){
        if(itemSpeed == 0.8f && coin >= 2250){
            itemSpeed = 0.7f;
            PlayerPrefs.SetFloat("Item Speed",0.7f);
            SetCoin(2250);
            tier3.interactable = false;
        }
    }

    void Tier4(){
        if(itemSpeed == 0.7f && coin >= 3000){
            itemSpeed = 0.6f;
            PlayerPrefs.SetFloat("Item Speed",0.6f);
            SetCoin(3000);
            tier4.interactable = false;
        }
    }
    
    void SetCoin(int removeCoin){
        coin -= removeCoin;
        PlayerPrefs.SetInt("Coin", coin);
    }
}
