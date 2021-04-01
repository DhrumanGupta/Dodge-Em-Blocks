using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerSpeed;
    public Rigidbody2D rb;
    public float rotSpeed;
    public bool moveLeft;
    public bool moveRight;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        playerSpeed = 8;
        rotSpeed = 200f;
        moveLeft = false;
        moveRight = false;
    }
 
    // Update is called once per frame
    void Update() {
    // Move Left
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.velocity = new Vector2(-playerSpeed, rb.velocity.y);
            transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            transform.Rotate(0, 0, 0);
        }
    // Move Right
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(playerSpeed, rb.velocity.y);
            transform.Rotate(0, 0, -rotSpeed * Time.deltaTime);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            transform.Rotate(0, 0, 0);
        }
        
        if (moveLeft){
            rb.velocity = new Vector2(-playerSpeed, rb.velocity.y);
            transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
            moveLeft = false;
        } else if (moveRight){
            rb.velocity = new Vector2(playerSpeed, rb.velocity.y);
            transform.Rotate(0, 0, -rotSpeed * Time.deltaTime);
            moveRight = false;
        }
    }
    
}
