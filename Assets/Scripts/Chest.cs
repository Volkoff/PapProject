using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chest : Interactible
{
    void start(){
        
    }
    protected override void OnInteracted()
    {
        base.OnInteracted();
        print("On chest interacted");
        SceneManager.LoadScene ("Level2");
    }
} 
