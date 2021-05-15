using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorDungeon : LeverPulling
{
    bool isPlayerInRange = false;
    public GameObject tip;

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
        if(isPlayerInRange && LeverPulled)
        {
            reset();
        } else
        {
            tip.SetActive(true);
            RemoveAfterSeconds(4,tip);
        } 
    }
        
    private void reset(){
        SceneManager.LoadScene(sceneName:"Dungeon");
    }
    IEnumerator RemoveAfterSeconds (int seconds, GameObject obj){
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
        reset();
    }
    void Update()
    {
        
        
    }
}
