using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    [SerializeField] float _fadeTime = 2.5f;
    [SerializeField] Image _fadeImage = default;
    float _time = 0f;

    public void OnCLickButton(string sceneName)
    {
        _fadeImage.enabled = true;
        StartCoroutine(Change(sceneName));
    }

    IEnumerator Change(string sceneName)
    {
        while (true)
        {
            _time += Time.deltaTime;
            Color c = _fadeImage.color;
            c.a = _time / _fadeTime;
            _fadeImage.color = c;
            if (_time >= _fadeTime)
            {
                Debug.Log("フェード完了");
                SceneManager.LoadScene(sceneName);
            }
            yield return null;
        }
        
    }
}
