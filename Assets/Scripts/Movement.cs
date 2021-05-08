using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float camRotY;
    public float speed = 0.05f;
    public float jumpForce = 5f;
    public float sensitivity = 2;

    public Vector3 jump = new Vector3(0.0f, 2.0f, 0.0f);
    public bool isGrounded;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        camRotY += sensitivity * Input.GetAxis("Mouse X");
        transform.localEulerAngles = new Vector3(0, camRotY, 0);


        if (Input.GetAxis("Horizontal") != 0 && isGrounded)
        {
            gameObject.transform.Translate(speed * Input.GetAxis("Horizontal"), 0, 0);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(0, 0, speed * Input.GetAxis("Vertical"));
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        if (Input.GetKey(KeyCode.LeftShift)) 
        {
            speed = 0.1f;
        } else
        {
            speed = 0.05f;
        }
    }
}
