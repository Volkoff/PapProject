using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    public GameObject platforms;
    void Update()
    {
        if(LeverPulling.LeverPulled){
            platforms.SetActive(true);
        }
    }
}
