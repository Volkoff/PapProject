using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorDungeon : Interactible
{
    private IEnumerator coroutine;
    bool isPlayerInRange = false;
    public GameObject tip;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isPlayerInRange = true;
            reset();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            isPlayerInRange = false;
        }
    }
    private void reset(){
        if (Checkpoint.isFirstPartDone)
        {
            float positionX = PlayerPrefs.GetFloat("Xvalue");
            float positionY = PlayerPrefs.GetFloat("Yvalue");
            float positionZ = PlayerPrefs.GetFloat("Zvalue");
            transform.position = new Vector3(positionX, positionY, positionZ);
        }
        else
        {
       SceneManager.LoadScene(sceneName:"Dungeon");
        }
        
    }
}
