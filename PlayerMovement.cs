using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Data
    public Rigidbody2D rb;
    public float speed = 5;
    public float jumpHeight = 5;
    public float gravity = 0.5f;
    public bool isOnGround = false;
    public LayerMask jumpMask;
    public float score = 0;
    public UIManager uiScript;
    public int jumpMultiplyer;
    public float spdMultiplyer;
    public float height;
    public float width;

    void Start(){
        //Get the Rigidbody2D component
        jumpMultiplyer = PlayerPrefs.GetInt("jumpMultiplyer");
        spdMultiplyer = PlayerPrefs.GetFloat("spdMultiplyer");
        rb = GetComponent<Rigidbody2D>();
        uiScript = GameObject.Find("Managers").GetComponent<UIManager>();

        width = PlayerPrefs.GetFloat("Player Width");
        height = PlayerPrefs.GetFloat("Player Height");

        transform.localScale = new Vector3(width * 2, height * 2, 1);
    }

    void Update(){
        if(!uiScript.paused){
        //Check if on ground
        Vector2 offset = new Vector2(rb.position.x, rb.position.y - 1);
        Vector2 size = new Vector2(0.9f,0.2f);
        if(Physics2D.OverlapBox(offset, size, 0, jumpMask)){
            isOnGround = true;
        } else {
            isOnGround = false;
        }
        //Get movement axis
        float hor = Input.GetAxis("Horizontal");
        float ver = -gravity;
        //Check if player is jumping
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround){
            Debug.Log("Player Jump");
            ver = 0;
            rb.AddForce(Vector2.up * ((jumpHeight + (jumpMultiplyer * 2)) * 1000));
        }
        //Move the player
        Vector2 movement = new Vector2(hor * (spdMultiplyer + 1),ver);

        rb.MovePosition(rb.position + movement);
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Antivirus")){
            uiScript.lost = true;
        }
    }
}
