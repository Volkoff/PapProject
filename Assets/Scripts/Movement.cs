using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    public float camRotY;
<<<<<<< HEAD
    public float speed = 0.2f;
=======
    public float speed = 0.02f;
>>>>>>> c975ee6fc8cc64ad4e7a416db4973a7e6c2b5d2e
    public float jumpForce = 10f;
    public float sensitivity = 2;
    int check;

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

<<<<<<< HEAD
    void OnCollisionStay()
    {
        isGrounded = true;
    }

=======
    string PrevScene = "Level1";
    void SceneManage(int check){
        if(check == 1){
            SceneManager.LoadScene("Escape screen");
        }
        if(check == 2){
            SceneManager.LoadScene(PrevScene);
        }
    }
>>>>>>> c975ee6fc8cc64ad4e7a416db4973a7e6c2b5d2e
    // Update is called once per frame
    void Update()
    {
        camRotY += sensitivity * Input.GetAxis("Mouse X");
        transform.localEulerAngles = new Vector3(0, camRotY, 0);

        if(Input.GetKeyDown("escape") && SceneManager.GetActiveScene().name == "Level1"){
            check = 1;
            PrevScene = SceneManager.GetActiveScene().name;
            SceneManage(check);
        }
        if(Input.GetKeyDown("escape") && SceneManager.GetActiveScene().name == "Escape screen"){
            check = 2;
            SceneManage(check);
        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            gameObject.transform.Translate(speed * Input.GetAxis("Horizontal"), 0, 0);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(0, 0, speed * Input.GetAxis("Vertical"));
        }
        if (Input.GetKey(KeyCode.Escape))
<<<<<<< HEAD
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
            speed = 0.6f;
        } else
        {
            speed = 0.2f;
=======
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
            speed = 0.06f;
        } else
        {
            speed = 0.02f;
>>>>>>> c975ee6fc8cc64ad4e7a416db4973a7e6c2b5d2e
        }
    }
}
