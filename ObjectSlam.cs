using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSlam : MonoBehaviour
{
    public GameObject proj;
    public int projCount = 2;
    public float spawnHeight;
    public float spawnXDif = 5;
    
    void Start(){
        for(int i = 0; i < projCount; i++){
            Vector3 pos = new Vector3(transform.position.x + Random.Range(-spawnXDif, spawnXDif), spawnHeight, 0);
            Instantiate(proj, pos, transform.rotation);
        }
        Destroy(gameObject);
    }
}
