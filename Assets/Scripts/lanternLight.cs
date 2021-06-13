using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanternLight : MonoBehaviour
{
    bool light = false;
    public GameObject lightObj;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        light = !light;
            lightObj.SetActive(light);
    }
}
