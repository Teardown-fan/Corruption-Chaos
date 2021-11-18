using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerAntivirusAI : MonoBehaviour
{
    public UIManager pauseScript;
    public float speed = 2f;
    public bool active = false;
    public GameObject target;
    public Rigidbody2D rb;

    void Start(){
        pauseScript = GameObject.Find("Managers").GetComponent<UIManager>();
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.CompareTag("Player")){
            float percent = PlayerPrefs.GetFloat("AntivirusRes");
            if(!Chance(percent)){
                target = collider.gameObject;
                active = true;
            }
        }
    }

    void Update(){
        if(active && !pauseScript.paused){
            if(target != null){
                rb.MovePosition(transform.position + (target.transform.position - transform.position).normalized * speed);
            }
        }
    }

    bool Chance(float percent){
        float i = Random.Range(1, 100/percent);
        if(i == 1){
            return true;
        }
        return false;
    }
}
