using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonBehaviour : Movement
{
    void Start()
    {
        Cursor.visible = true;
    }
    public void ResumeClick()
    {
        SceneManager.LoadScene(PrevScene);
        //Cursor.visible = false;
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