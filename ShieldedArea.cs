using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldedArea : MonoBehaviour
{
    public float flingDirection = 4;
    public float flingForce = 5;

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.CompareTag("Player")){
            Rigidbody2D rb = collider.gameObject.GetComponent<Rigidbody2D>();
            switch(flingDirection){
                case 1:
                rb.AddForce(Vector2.up * (flingForce * 1000));
                break;
                case 2:
                rb.AddForce(Vector2.right * (flingForce * 1000));
                break;
                case 3:
                rb.AddForce(Vector2.down * (flingForce * 1000));
                break;
                case 4:
                rb.AddForce(Vector2.left * (flingForce * 1000));
                break;
            }
        }
    }
}
