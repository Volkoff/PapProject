using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    float sensitivity = 5;
    float camRotX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        camRotX -= sensitivity * Input.GetAxis("Mouse Y");
        camRotX = Mathf.Clamp(camRotX, 300, 420);
        transform.localEulerAngles = new Vector3(camRotX, 0, 0);
    }
}

