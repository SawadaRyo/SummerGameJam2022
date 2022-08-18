using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressManager : SingletonMonoBehaviour<ProgressManager>
{
    public float Distance => _distance;

    [SerializeField]
    [Header("�G�l�~�[���ړ����J�n���鎞��")]
    float _startTime = 5f;

    /// <summary>�v���C���[�ƃG�l�~�[�̋���</summary>
    float _distance;

    float _timer;

    const float OFFSET = 100;

    void Update()
    {
        _timer += Time.deltaTime;
        _distance = ProgressUIManager.Instance.PlayerProgressValue - ProgressUIManager.Instance.EnemyProgressValue;

        ProgressUIManager.Instance.ChangePlayerProgress(Time.deltaTime / OFFSET);

        if (_timer >= _startTime)
        {
            ProgressUIManager.Instance.ChangeEnemyProgress(Time.deltaTime / OFFSET);
        }
    }
}
