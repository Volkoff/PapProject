using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonBehaviour : Movement
{
    public Button Resume;
    void Update()
    {
       
    }
    public void ResumeClick()
    {
        SceneManager.LoadScene(PrevScene);
    }
    public void NewGameClick()
    {
        SceneManager.LoadScene("Level1");
    }
    public void ExitClick()
    {
        Application.Quit();
    }
}
