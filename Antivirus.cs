using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Antivirus : MonoBehaviour
{
    public Button tier1;
    public Button tier2;
    public Button tier3;
    public Button tier4;
    public Button tier5;
    public Button tier6;
    public Button tier7;
    public Button tier8;

    public int antivirusRes;
    public int coin;

    void Start(){
        tier1 = gameObject.transform.Find("Tier 1").GetComponent<Button>();
        tier2 = gameObject.transform.Find("Tier 2").GetComponent<Button>();
        tier3 = gameObject.transform.Find("Tier 3").GetComponent<Button>();
        tier4 = gameObject.transform.Find("Tier 4").GetComponent<Button>();
        tier5 = gameObject.transform.Find("Tier 5").GetComponent<Button>();
        tier6 = gameObject.transform.Find("Tier 6").GetComponent<Button>();
        tier7 = gameObject.transform.Find("Tier 7").GetComponent<Button>();
        tier8 = gameObject.transform.Find("Tier 8").GetComponent<Button>();

        tier1.onClick.AddListener(Tier1);
        tier2.onClick.AddListener(Tier2);
        tier3.onClick.AddListener(Tier3);
        tier4.onClick.AddListener(Tier4);
        tier5.onClick.AddListener(Tier5);
        tier6.onClick.AddListener(Tier6);
        tier7.onClick.AddListener(Tier7);
        tier8.onClick.AddListener(Tier8);

        antivirusRes = PlayerPrefs.GetInt("AntivirusRes");

        switch(antivirusRes){
            case 20:
            tier1.interactable = false;
            break;
            case 30:
            tier1.interactable = false;
            tier2.interactable = false;
            break;
            case 40:
            tier1.interactable = false;
            tier2.interactable = false;
            tier3.interactable = false;
            break;
            case 50:
            tier1.interactable = false;
            tier2.interactable = false;
            tier3.interactable = false;
            tier4.interactable = false;
            break;
            case 60:
            tier1.interactable = false;
            tier2.interactable = false;
            tier3.interactable = false;
            tier4.interactable = false;
            tier5.interactable = false;
            break;
            case 70:
            tier1.interactable = false;
            tier2.interactable = false;
            tier3.interactable = false;
            tier4.interactable = false;
            tier5.interactable = false;
            tier6.interactable = false;
            break;
            case 80:
            tier1.interactable = false;
            tier2.interactable = false;
            tier3.interactable = false;
            tier4.interactable = false;
            tier5.interactable = false;
            tier6.interactable = false;
            tier7.interactable = false;
            break;
            case 90:
            tier1.interactable = false;
            tier2.interactable = false;
            tier3.interactable = false;
            tier4.interactable = false;
            tier5.interactable = false;
            tier6.interactable = false;
            tier7.interactable = false;
            tier8.interactable = false;
            break;
        }
    }
    
    void Update(){
        coin = PlayerPrefs.GetInt("Coin");
    }

    void Tier1(){
        if(antivirusRes == 10 && coin >= 1000){
            antivirusRes = 20;
            PlayerPrefs.SetInt("AntivirusRes", 20);
            SetCoin(1000);
            tier1.interactable = false;
        }
    }

    void Tier2(){
        if(antivirusRes == 20 && coin >= 2500){
            antivirusRes = 30;
            PlayerPrefs.SetInt("AntivirusRes", 30);
            SetCoin(2500);
            tier2.interactable = false;
        }
    }

    void Tier3(){
        if(antivirusRes == 30 && coin >= 4000){
            antivirusRes = 40;
            PlayerPrefs.SetInt("AntivirusRes", 40);
            SetCoin(4000);
            tier3.interactable = false;
        }
    }

    void Tier4(){
        if(antivirusRes == 40 && coin >= 5500){
            antivirusRes = 50;
            PlayerPrefs.SetInt("AntivirusRes", 50);
            SetCoin(5500);
            tier4.interactable = false;
        }
    }

    void Tier5(){
        if(antivirusRes == 50 && coin >= 7000){
            antivirusRes = 60;
            PlayerPrefs.SetInt("AntivirusRes", 60);
            SetCoin(7000);
            tier5.interactable = false;
        }
    }

    void Tier6(){
        if(antivirusRes == 60 && coin >= 8500){
            antivirusRes = 70;
            PlayerPrefs.SetInt("AntivirusRes", 70);
            SetCoin(8500);
            tier6.interactable = false;
        }
    }

    void Tier7(){
        if(antivirusRes == 70 && coin >= 10000){
            antivirusRes = 80;
            PlayerPrefs.SetInt("AntivirusRes", 80);
            SetCoin(10000);
            tier7.interactable = false;
        }
    }

    void Tier8(){
        if(antivirusRes == 80 && coin >= 11500){
            antivirusRes = 90;
            PlayerPrefs.SetInt("AntivirusRes", 90);
            SetCoin(11500);
            tier8.interactable = false;
        }
    }

    void SetCoin(int removeCoin){
        coin -= removeCoin;
        PlayerPrefs.SetInt("Coin", coin);
    }
}
