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

  
    void Start()
    {
        

    }

  
    void Update()
    {
        if(scoreIncreasing){

             scoreCount += pointPerSecond * Time.deltaTime;

        }
        if(scoreCount > hiScoreCount){
            hiScoreCount = scoreCount;
        }


        scoreText.text = "Distance: " + Mathf.Round (scoreCount);  
        hiScoreText.text= "Best: " + Mathf.Round(hiScoreCount);


    }
}
