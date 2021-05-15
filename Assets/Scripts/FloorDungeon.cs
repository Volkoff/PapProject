using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FloorDungeon : Interactible
{
    bool isPlayerInRange = false;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isPlayerInRange = true;
            Restart(isPlayerInRange);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            isPlayerInRange = false;
            Restart(isPlayerInRange);
        }
    }

    private void Restart(bool isPlayerInRange)
    {
        if(isPlayerInRange)
        {
            SceneManager.LoadScene(sceneName:"Dungeon");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        
    }
}
