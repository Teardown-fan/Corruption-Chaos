using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeatureAI : MonoBehaviour
{
    //Data
    public Rigidbody2D rb;
    public float speed = 1;
    public float speedMult;
    public float jumpHeight = 4f;
    public GameObject player;
    public float gravity = 0.5f;
    public LayerMask jumpMask;
    public float score = 1;
    public float scoreMult;
    public CreateFeatures featuresScript;
    public Vector2 allowedRange;
    public UIManager uiScript;
    public Vector2 lockPos;

    void Start(){
        //Get player and Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Win");
        featuresScript = GameObject.Find("Managers").GetComponent<CreateFeatures>();
        uiScript = GameObject.Find("Managers").GetComponent<UIManager>();

        scoreMult = PlayerPrefs.GetFloat("Item Score");
        speedMult = PlayerPrefs.GetFloat("Item Speed");

        score = score * scoreMult;
    }

    void Update()
    {
        //AI
        if (uiScript.paused)
        {
            lockPos = rb.position;
            rb.MovePosition(lockPos);
        }
        if (!uiScript.paused)
        {
            if (CompareVector3s(player.transform.position - transform.position, new Vector3(5, 5, 5)))
            {
                Vector2 playerPos = new Vector2(player.transform.position.x, player.transform.position.y);
                Vector2 moveDirection = (playerPos - rb.position).normalized / 2 * (speed * speedMult);
                //Move AI
                rb.MovePosition(rb.position + moveDirection);
            }
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        Reset();
    }

    bool inRange(float min, float max, float num){
        if(num < max && num > min){
            return true;
        }
        return false;
    }

    void Reset(){
        rb.MovePosition(new Vector2(0,0));
    }

    bool CompareVector3s(Vector3 a, Vector3 b){
        if(a.x < b.x){
            return true;
        }
        if(a.y < b.y){
            return true;
        }
        return false;
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player")){
            PlayerMovement playerScript = collision.gameObject.GetComponent<PlayerMovement>();
            playerScript.score += score;
            featuresScript.featureCount -= 1;
            Destroy(gameObject);
        }
    }
}
