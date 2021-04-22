using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactible : MonoBehaviour
{
    bool isPlayerInRange = false;
    void Update()
    {
        CheckForInteraction();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            isPlayerInRange = false;
        }
    }

    void CheckForInteraction()
    {
        if(isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            OnInteracted();
        }
    }

    protected virtual void OnInteracted()
    {
        print("On interacted");
    }
}
