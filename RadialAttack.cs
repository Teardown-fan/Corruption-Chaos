using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialAttack : MonoBehaviour
{
    public GameObject proj;
    public int count = 10;
    public float speed = 500;

    void Start(){
        for(int i = 0; i < count; i++){
            float radius = 360/count * i;
            GameObject projObj = Instantiate(proj, transform.position, new Quaternion(0,0,radius,1));
            projObj.GetComponent<Rigidbody2D>().AddForce(projObj.transform.up * speed);
        }
        Destroy(gameObject);
    }

    void Delay(float delay){
        float delayTime = Time.time + delay;
        while(delayTime < Time.time){
            continue;
        }
        return;
    }
}
