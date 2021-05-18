using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    float sensitivity = 5;
    float camRotX;
    
    /// <summary>
    /// Cursor stays in the centre position
    /// </summary>
    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        camRotX -= sensitivity * Input.GetAxis("Mouse Y");
        camRotX = Mathf.Clamp(camRotX, 300, 420);
        transform.localEulerAngles = new Vector3(camRotX, 0, 0);
    }
}

