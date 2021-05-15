using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    public float camRotY;
    public float speed = 0.08f;
    public float jumpForce = 0.5f;
    public float sensitivity = 2;
    int check;

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

    string PrevScene = "Level1";
    void SceneManage(int check){
        if(check == 1){
            SceneManager.LoadScene("Escape screen");
        }
        if(check == 2){
            SceneManager.LoadScene(PrevScene);
        }
    }
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, jumpForce, 0);
        }
         if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    
    }
}
