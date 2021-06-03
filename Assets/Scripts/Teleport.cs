using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Teleport : Interactible
{
    public string sceneName;
    protected override void OnInteracted()
    {
        base.OnInteracted();
        SceneManager.LoadScene(sceneName);
    }
} 
