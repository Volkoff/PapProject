using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEmitting : MonoBehaviour
{
    public float speed;
    public float endRange;
    public Light light;

    void Update()
    {
        if(light.range <= endRange)
        {
            light.range += speed*Time.deltaTime;
        }
    }
}
