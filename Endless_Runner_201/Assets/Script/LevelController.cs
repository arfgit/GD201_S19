using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour{

    public float scrollSpeed = 5.0f;
    public GameObject[] floors;
    public float frequency = 0.5f;
    float counter = 0.0f;
    public Transform challengesSpawnPoint;

    void Start(){
    GenerateFloorChallenge();

    }

    
    void Update(){

        //generate

        if(counter <= 0.0f){
        
            GenerateFloorChallenge();

        } else
        {
            counter -= Time.deltaTime * frequency;
        }
    

        //scroll
         GameObject currentChild;
        
        for(int i = 0; i < transform.childCount; i++){

            currentChild = transform.GetChild(i).gameObject;
            ScrollChallenge(currentChild);
            if(currentChild.transform.position.x <= -45.0f){

            Destroy(currentChild);
            }
        }




    }

    void ScrollChallenge(GameObject currentChallenge){
            currentChallenge.transform.position -= Vector3.right * (scrollSpeed * Time.deltaTime);

            
        
    }
    void GenerateFloorChallenge(){
        GameObject newLevel = Instantiate (floors[Random.Range(0, floors.Length)], challengesSpawnPoint.position, Quaternion.identity) as GameObject;
        newLevel.transform.parent = transform;
        counter = 1.0f;

    
    }
}
