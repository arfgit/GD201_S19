using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
        public Transform platformGenerator;
        private Vector3 platformStartPoint;

        public PlayerController thePlayer;
        private Vector3 playerStarterPoint;
  
    void Start()
    {
        platformStartPoint = platformGenerator.position;
        playerStarterPoint = thePlayer.transform.position;

    }

   
    void Update()
    {
        
    }


    public void RestartGame()
    {
        StartCoroutine ("RestartGameCo");


    }

    /*  public IEnumerator RestartGameCo()
    {

        thePlayer.transform.position = playerStarterPoint;





    }
    */
}
