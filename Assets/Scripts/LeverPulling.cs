using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverPulling : Interactible
{
    bool LeverPulled = false;
    protected override void OnInteracted()
    {
        base.OnInteracted();
        print("Lever was pulled");
        LeverPulled = true;
    }
}
