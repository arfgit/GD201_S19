using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phaseSound : MonoBehaviour
{
    public AudioSource phase;

    void Update(){

        if(Input.GetKeyDown(KeyCode.Space)){
                
            phase.Play();

        }

        }




    }

