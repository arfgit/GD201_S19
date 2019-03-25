using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointPerSecond;

    public bool scoreIncreasing;

    private ScoreManager theScoreManager;

  
    void Start()
    {
        if(PlayerPrefs.GetFloat("Best") != null){

            hiScoreCount = PlayerPrefs.GetFloat("Best");

        }

    }

  
    void Update()
    {
        if(scoreIncreasing){

             scoreCount += pointPerSecond * Time.deltaTime;

        }
        if(scoreCount > hiScoreCount){
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("Best", hiScoreCount);
        }


        scoreText.text = "Distance: " + Mathf.Round (scoreCount);  
        hiScoreText.text= "Best: " + Mathf.Round(hiScoreCount);


    }
     void OnTriggerEnter2D(Collider2D other){

      if(other.tag == "FallDetector"){
       scoreCount = 0;
       scoreIncreasing = true;
        }else{
            scoreIncreasing = false;


        }



    }
}
