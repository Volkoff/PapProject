using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LeverPulling : Interactible
{
    public static bool LeverPulled = false;
    public GameObject LeverDown;
    public GameObject LeverUp;
    
    void Start()
    {
        UpdateStateOfLever();
    }

    protected override void OnInteracted()
    {
        LeverPulled = !LeverPulled;
        print("Lever was pulled " + LeverPulled);
        UpdateStateOfLever();
    }

    private void UpdateStateOfLever()
    {
        LeverDown.SetActive(LeverPulled);
        LeverUp.SetActive(!LeverPulled);
    }
}
