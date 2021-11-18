using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlamObject : MonoBehaviour
{
    public float speed = 2f;

    void Update(){
        transform.Translate(new Vector3(0,speed,0));
    }

    void OnCollisionEnter2D(Collision2D collision){
        Destroy(gameObject);
    }
}
