using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadGame()
    {

    }

    public void Help()
    {
        SceneManager.LoadScene("HelpScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}
