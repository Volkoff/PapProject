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
	    print("test");
        SceneManager.LoadScene("Dungeon");
    }
} 
