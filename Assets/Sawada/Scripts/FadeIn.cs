using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [Header("フェードさせる時間")]
    [SerializeField] float _fadeTime = 2.5f;
    [Header("フェードさせる画面")]
    [SerializeField] Image _fadeImage = default;

    float _time = 0f;
    PauseHander _hander = default;
    void Start()
    {
        _time = _fadeTime;
        _hander = GameObject.FindObjectOfType<PauseHander>();
        if (_hander != null) _hander.IntervalPause(true);
        StartCoroutine(Change());
    }
    IEnumerator Change()
    {
        while (true)
        {
            _time -= Time.deltaTime;
            Color c = _fadeImage.color;
            c.a = _time / _fadeTime;
            _fadeImage.color = c;
            if (_time <= 0)
            {
                _fadeImage.enabled = false;
                if (_hander != null) _hander.IntervalPause(false);
                yield break;
            }
            yield return null;
        }

    }
}
