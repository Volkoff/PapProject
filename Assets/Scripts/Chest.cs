using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Interactible
{
    public GameObject Finish;
    void start(){
        
    }
    protected override void OnInteracted()
    {
        base.OnInteracted();
        print("On chest interacted");
        Finish.SetActive(true);
    }
} 
