using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float flingUp = 5f;

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Feature") || collision.gameObject.CompareTag("Player")){
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * (flingUp * 1000));
        }
    }
}
