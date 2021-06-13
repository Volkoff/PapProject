using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endingGame : Interactible
{
    public string SceneName;
    public GameObject theEndText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            RemoveAfterSeconds(5, theEndText, SceneName);
        }
    }

    IEnumerator RemoveAfterSeconds(int seconds, GameObject obj, string SceneName)
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
        SceneManager.LoadScene(sceneName:SceneName);
    }
}
