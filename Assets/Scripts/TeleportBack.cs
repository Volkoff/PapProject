using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TeleportBack : Interactible
{
    public GameObject player;
    protected override void OnInteracted()
    {
        base.OnInteracted();
        SceneManager.LoadScene("Level1");
        player.transform.position = new Vector3(1376, 28, 1215);
    }
}