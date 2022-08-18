using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallHole : MonoBehaviour
{
    [Tooltip("基準値")] Vector2 _normalPos = new Vector2(0,0);
    [Tooltip("プレイヤー座標")]Vector2 _playerPos;
    void Start()
    {
        _playerPos = GameObject.Find("Player").GetComponent<Transform>().position;
    }

    void Update()
    {
        Vector2 diff = _playerPos - _normalPos;

        //if(diff.magnitude < -4.5 )
        //{
        //    SceneManager.LoadScene("GameOver");       //穴に落ちたらゲームオーバー
        //}
    }
}
