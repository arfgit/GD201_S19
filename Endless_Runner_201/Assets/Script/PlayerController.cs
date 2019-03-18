using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{  
     public float speed; //controls the characters movement speed
     public float jumpForce; //controls the characters jump
     private float moveInput; //key movement 
     private Rigidbody2D rb; //rigidbody

     private bool facingRight = true; //for when we implement a sprite for the character

     private bool isGrounded; 
     public Transform groundCheck; //checks to see if character is grounded
     public float checkRadius; 
     public LayerMask whatIsGround;

     private int numJump; //how many jumps does the player get
    public int numJumpValue; //Set the value for the jumps

    public bool pressed;

      void Start(){
        rb = GetComponent<Rigidbody2D>();


    }

    
    void FixedUpdate(){

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);




      /*   moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        */
  /*  if(facingRight == false && moveInput > 0){

        Flip();
    }
    if(facingRight == true && moveInput > 0){ //this is for when we add a better                                                    character sprite
         Flip();
    } */


    }

    void Update(){

        if(isGrounded == true){
            numJump = numJumpValue;

        }

      if(Input.GetKeyDown(KeyCode.W) && numJump > 0){
            rb.velocity = Vector2.up * jumpForce;
            numJump--;


        }

        if(Input.GetKeyDown(KeyCode.W) && numJump == 0 && isGrounded == true){
            rb.velocity = Vector2.up * jumpForce;

        } 
        rb.velocity = new Vector2(speed, rb.velocity.y);

       /*  if(Input.GetKeyDown(KeyCode.W)){

            rb.velocity = new Vector2 (rb.velocity.x, jumpForce);





        } */

      /*    if(Input.GetKeyDown (KeyCode.Space)){
              if(!pressed){
           GetComponent<SpriteRenderer>().color = new 
            Color (42, 148, 209, 255f);
            pressed = true;
              }
        }
        else if(Input.GetKeyUp (KeyCode.Space)){

           GetComponent<SpriteRenderer>().color = new Color (42, 148, 209, 1f);
            pressed = false;

        } 
        PLAYER SHOULD CHANGE COLOR WHEN THE KEY IS PRESSED, BUT THEN CHANGE BACK WHEN THE KEY IS RELEASED.
        
        */
        
       

    }

    void Flip(){
facingRight = !facingRight;
Vector3 Scaler = transform.localScale;
Scaler.x *= -1;
transform.localScale = Scaler;


    }
    /*   void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Bad")){
            Destroy(col.gameObject);

        }
    }
    */
  
}
