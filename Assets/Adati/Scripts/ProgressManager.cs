using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressManager : SingletonMonoBehaviour<ProgressManager>
{
    public float Speed => _speed;
    public float StartTime => _startTime;
    public float Distance => _distance;

    [SerializeField]
    [Header("進行度のスピード")]
    float _speed = 1;

    [SerializeField]
    [Header("エネミーが移動を開始する時間")]
    float _startTime = 5f;

    /// <summary>プレイヤーとエネミーの距離</summary>
    float _distance;

    const float OFFSET = 100;

    void Update()
    {
        _distance = ProgressUIManager.Instance.PlayerProgressValue - ProgressUIManager.Instance.EnemyProgressValue;
        ProgressUIManager.Instance.ChangePlayerProgress(Time.deltaTime / OFFSET * _speed);

        if (TimeManager.Instance.Timer >= _startTime)
        {
            ProgressUIManager.Instance.ChangeEnemyProgress(Time.deltaTime / OFFSET * _speed);
        }
    }
}
