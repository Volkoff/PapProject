using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Chest : Interactible
{
    public GameObject Finish;
    protected override void OnInteracted()
    {
        base.OnInteracted();
        Finish.SetActive(true);
        print("test");
        SceneManager.LoadScene(sceneName:"Dungeon");
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
             SceneManager.LoadScene (sceneName:"Escape screen");
        }
    }
} 
