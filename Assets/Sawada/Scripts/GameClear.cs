using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClear : MonoBehaviour
{
    [SerializeField] string _sceneName = "GameClearScenr";
    LoadSceneManager _load = default;
    PauseHander _hander = default;
    void Start()
    {
        _load = GameObject.FindObjectOfType<LoadSceneManager>(); 
        _hander = GameObject.FindObjectOfType<PauseHander>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Player>(out Player p))
        {
            _hander.IntervalPause(true);
            _load.OnCLickButton(_sceneName);
        }
    }
}
