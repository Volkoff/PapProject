using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionInTheBegin : Interactible
{
    public GameObject instructions;
    void start()
    {
        instructions.SetActive(false);
    }
    private void OnTriggerEnter()
    {
        instructions.SetActive(true);
    }

    private void OnTriggerExit()
    {
        instructions.SetActive(false);
    }
}
