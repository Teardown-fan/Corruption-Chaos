using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDelay : MonoBehaviour
{
    public float breakTime = 3;

    void Update(){
        if(breakTime == Time.time){
            Destroy(gameObject);
        }
    }
}
