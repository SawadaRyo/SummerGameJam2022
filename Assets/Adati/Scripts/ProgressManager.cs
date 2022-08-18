using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressManager : SingletonMonoBehaviour<ProgressManager>
{
    public float Speed => _speed;
    public float StartTime => _startTime;
    public float Distance => _distance;

    [SerializeField]
    [Header("�i�s�x�̃X�s�[�h")]
    float _speed = 1;

    [SerializeField]
    [Header("�G�l�~�[���ړ����J�n���鎞��")]
    float _startTime = 5f;

    /// <summary>�v���C���[�ƃG�l�~�[�̋���</summary>
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
