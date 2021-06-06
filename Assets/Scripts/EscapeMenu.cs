using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeMenu : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject EscapeScreenUI;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (isPaused)
            {
                Resume();
            } else
            {
                Pause();
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;
            }
        }
       
    }

    public void Resume()
    {
        EscapeScreenUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.visible = false;
    }

    public void Pause()
    {
        EscapeScreenUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void NewGame()
    {
        SceneManager.LoadScene(sceneName: "Level1");
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("Xvalue", transform.position.x);
        PlayerPrefs.SetFloat("Yvalue", transform.position.y);
        PlayerPrefs.SetFloat("Zvalue", transform.position.z);
        PlayerPrefs.Save();

    }

    public void Load()
    {
        float positionX = PlayerPrefs.GetFloat("Xvalue");
        float positionY = PlayerPrefs.GetFloat("Yvalue");
        float positionZ = PlayerPrefs.GetFloat("Zvalue");
        transform.position = new Vector3(positionX, positionY, positionZ);
    }

    public void ExitClick()
    {
        SceneManager.LoadScene(sceneName: "MainMenu");
    }
}
