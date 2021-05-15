using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : LeverPulling
{
    public GameObject platforms;
    void Update()
    {
        if(LeverPulled){
            platforms.SetActive(true);
        }
    }
}
