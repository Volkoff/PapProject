using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Interactible
{
    protected override void OnInteracted()
    {
        base.OnInteracted();
        print("On chest interacted");
    }
} 
