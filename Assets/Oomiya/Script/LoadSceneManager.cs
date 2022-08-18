using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    public void OnCLickButton(string sceneName)
    {
        StartCoroutine(Change(sceneName));
    }

    IEnumerator Change(string sceneName)
    {
        yield return new WaitForSeconds(2.5f);

        SceneManager.LoadScene(sceneName);
    }
}
