using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour{  
     public float speed; //controls the characters movement speed

     public float speedMultiplier;

     public float Milestone;
     private float speedMilestoneCount;
     public float jumpForce; //controls the characters jump
     //public float gravity; //grav

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
    public Vector3 respawnPoint;

    public float gravity = 9.81f;
   public ForceMode2D forceMode;
  

    

    

      void Start(){
        rb = GetComponent<Rigidbody2D>();
     
      

    }

    
    void FixedUpdate(){

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);


      rb.AddForce(Vector2.down * gravity, forceMode); 

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

    void Update()
    {


        //  if(transform.position.x > speedMilestoneCount){
        //  speedMilestoneCount += Milestone;

        // speed = speed * speedMultiplier;






        if (isGrounded == true)
        {
            numJump = numJumpValue;

        }


        if (Input.GetKeyDown(KeyCode.W) && numJump > 0)
        {
            rb.velocity = Vector2.up * (jumpForce - 1) * Time.deltaTime;
            numJump--;


        }

        if (Input.GetKeyDown(KeyCode.W) && numJump == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;

        }
        rb.velocity = new Vector2(speed, rb.velocity.y);








        /*  if(Input.GetKeyDown(KeyCode.W)){

             rb.velocity = new Vector2 (rb.velocity.x, jumpForce);





         } */

        if (Input.GetKey(KeyCode.Space))
        {
         

                GetComponent<SpriteRenderer>().color = new
                 Color(42f/255, 148f/255, 209f/255, .5f);
                
            

        }
        else 
        {

            GetComponent<SpriteRenderer>().color = new Color( 42f/255, 148f / 255, 209f / 255, 1f);


        }
    }
        //PLAYER SHOULD CHANGE COLOR WHEN THE KEY IS PRESSED, BUT THEN CHANGE BACK WHEN THE KEY IS RELEASED.
        
      
    
       

    

   /* void Flip(){
facingRight = !facingRight;
Vector3 Scaler = transform.localScale;
Scaler.x *= -1;
transform.localScale = Scaler;


    } */

    void OnCollisionEnter2D (Collision2D col){
    if (col.gameObject.tag == "Bad") {
        this.gameObject.SetActive(false);
        SceneManager.LoadScene("Game Over Screen");
      
    }
}
  

    void OnTriggerEnter2D(Collider2D other){
      if (other.tag == "FallDetector"){
        SceneManager.LoadScene("Game Over Screen");



      }
    /*  if(other.gameObject.CompareTag("Bad")){
        this.gameObject.SetActive(false);



      } */



    }

    
  
    
  
}
