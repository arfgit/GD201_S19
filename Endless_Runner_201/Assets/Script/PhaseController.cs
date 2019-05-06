using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseController : MonoBehaviour
{

    void Start()
    {
        
       
    }

    
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
         

             GetComponent<BoxCollider2D> ().isTrigger = true;
                
            
        

        }
        else 
        {

           GetComponent<BoxCollider2D> ().isTrigger = false;

    
        }

    }
   /*   void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Bad"){
            Destroy (gameObject);

        } 
    } */
}

