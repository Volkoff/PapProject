using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float camRotY;
    public float speed = 0.3f;
    public float jumpForce = 2f;
    public float sensitivity = 2;
    public GameObject LightningLantern;
    bool lightning = false;

    private float sprintTimer = 0;
    private float sprintRest = 0;

    private IEnumerator coroutine;

    public Vector3 jump = new Vector3(0.0f, 2.0f, 0.0f);
    public bool isGrounded;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        camRotY += sensitivity * Input.GetAxis("Mouse X");
        transform.localEulerAngles = new Vector3(0, camRotY, 0);

         if (Input.GetMouseButtonDown(1)){
             lightningLantern();
         }
        if (Input.GetAxis("Horizontal") != 0)
        {
            gameObject.transform.Translate(speed * Input.GetAxis("Horizontal"), 0, 0);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(0, 0, speed * Input.GetAxis("Vertical"));
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        }
        Sprinting();
    }

    void Sprinting()
    {
    if (Input.GetKey(KeyCode.LeftShift) && isGrounded && sprintTimer<3) 
        {
            speed = 0.7f;
            sprintTimer += Time.deltaTime;
        }
        else
        {
            speed = 0.3f;
            sprintRest += Time.deltaTime;
            if (sprintRest >= 3)
            {
                sprintTimer = 0;
                sprintRest = 0;
            }
        }
    }

    void lightningLantern()
    {
        lightning = !lightning;
        LightningLantern.SetActive(lightning);
    }
   
}