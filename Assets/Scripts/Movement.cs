using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float camRotY;
    public float speed = 0.02f;
    public float jumpForce = 5f;
    public float sensitivity = 2;
    private float sprintTimer = 0f;
    public GameObject LightningLantern;
    bool lightning = false;

    bool sprinting = true;
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
        
        if (Input.GetKey(KeyCode.LeftShift) && isGrounded) 
        {   
            if(sprinting){
                Invoke("updateTimer",1);
                sprinting = false;
            }
            if(sprintTimer<3){
                speed = 0.06f;
            }else{
                speed = 0.02f;
            }
        } 
}

void lightningLantern(){
    lightning = !lightning;
    LightningLantern.SetActive(lightning);
}
void updateTimer(){
            if(sprintTimer >=3){
                sprintTimer = 0;
            }
            sprintTimer++;
            sprinting = true;
            
        }
}