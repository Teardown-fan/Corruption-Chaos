using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftwareLock : MonoBehaviour
{
    public float requiredScore = 75f;
    public float flingDirection = 2;
    public float flingForce = 5;

    void OnCollisionEnter2D(Collision2D collision){
        float score = collision.gameObject.GetComponent<PlayerMovement>().score;
        if (score >= requiredScore)
        {
            Destroy(gameObject);
        }
    }
}
