using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPulling : Interactible
{
    public GameObject LeverDown;
    public GameObject LeverUp;
    public GameObject platforms;
    public bool LeverPulled = false;

    void Start()
    {
        UpdateStateOfLever();
    }

    protected override void OnInteracted()
    {
        LeverPulled = !LeverPulled;
        print("Lever was pulled " + LeverPulled);
        UpdateStateOfLever();
        platforms.SetActive(false);
    }

    private void UpdateStateOfLever()
    {
        LeverDown.SetActive(LeverPulled);
        LeverUp.SetActive(!LeverPulled);
    }
}
