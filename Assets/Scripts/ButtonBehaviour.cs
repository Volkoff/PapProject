using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBehaviour : EscapeMenu
{
    void Start()
    {
        Cursor.visible = true;
    }
    public void ResumeClick()
    {
        Resume();
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