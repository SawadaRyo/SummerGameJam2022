using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("スコアの合計")] private int _sumScore;
    [Tooltip("一時停止中かどうか")] bool _isPause;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SumScore(int score)
    {
        _sumScore += score;
    }

    /// <summary>
    /// ゲームを一時停止する
    /// </summary>
    public void Pause()
    {
        if(!_isPause)
        {
            _isPause = true;
            Time.timeScale = 0;
            Debug.Log("止まりました");
        }
        else if(_isPause)
        {
            _isPause = false;
            Time.timeScale = 1;
            Debug.Log("動きました");
        }
        
    }
}
