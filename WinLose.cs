using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    public float negScore = 0;
    public float score = 0;
    public PlayerMovement playerScript;
    public CreateFeatures featuresScript;

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Feature")){
            //Add to negScore
            negScore -= collision.gameObject.GetComponent<FeatureAI>().score;
            Destroy(collision.gameObject);
            featuresScript.featureCount -= 1;
        }
    }

    void Start(){
        playerScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
        featuresScript = GameObject.Find("Managers").GetComponent<CreateFeatures>();
    }

    void Update(){
        score = playerScript.score;
    }
}
