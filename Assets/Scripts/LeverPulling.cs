using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LeverPulling : Interactible
{
    public GameObject LeverDown;
    public GameObject LeverUp;
    public GameObject cube;
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
        cube.SetActive(false);
SceneManager.LoadScene("Dungeon");
    }

    private void UpdateStateOfLever()
    {
        LeverDown.SetActive(LeverPulled);
        LeverUp.SetActive(!LeverPulled);
    }
}
