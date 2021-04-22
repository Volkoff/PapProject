using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactible : MonoBehaviour
{
    void Update()
    {
        CheckForInteraction();
    }

    void CheckForInteraction()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            OnInteracted();
        }
    }

    protected virtual void OnInteracted()
    {
        print("On interacted");
    }
}
