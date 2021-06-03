using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionInTheBegin : Interactible
{
    public GameObject instructions;
    private void OnTriggerEnter()
    {
        instructions.SetActive(true);
    }

    private void OnTriggerExit()
    {
        instructions.SetActive(false);
    }
    void Update()
    {
        
    }
}
