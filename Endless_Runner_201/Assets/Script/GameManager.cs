using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
        public Transform platformGenerator;
        private Vector3 platformStartPoint;

        public PlayerController thePlayer;
        private Vector3 playerStarterPoint;

 
  
    void Start()
    {
  

    }

   
    void Update()
    {
  
    }


    public void RestartGame()
    {
        StartCoroutine ("RestartGameCo");


    }

   
}
