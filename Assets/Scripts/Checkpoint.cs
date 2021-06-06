using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : Interactible
{

    public bool isFirstPartDone = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isFirstPartDone = true;
            PlayerPrefs.SetFloat("Xvalue", transform.position.x);
            PlayerPrefs.SetFloat("Yvalue", transform.position.y);
            PlayerPrefs.SetFloat("Zvalue", transform.position.z);
            PlayerPrefs.Save();
        }
    }
}
