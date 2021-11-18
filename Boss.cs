using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float health = 100;
    public int attackDelay = 5;
    public GameObject[] attacks;
    
    public int numberOfAttacks = 1;

    void Attack(){
        int selAttack = Random.Range(0,numberOfAttacks);
        Instantiate(attacks[selAttack], transform.position, transform.rotation);
    }

    void Update(){
        if(IsMultiple(Time.time, attackDelay)){
            Attack();
        }
        if(health <= 0){
            GameObject.Find("Managers").GetComponent<UIManager>().won = true;
            Destroy(gameObject);
        }
    }

    bool IsMultiple(float num, int multipleOf){
        float editedNum = num/multipleOf;
        if(editedNum == Mathf.Floor(editedNum)){
            return true;
        }
        return false;
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.CompareTag("Player")){
            health -= 10;
        }
    }
}
