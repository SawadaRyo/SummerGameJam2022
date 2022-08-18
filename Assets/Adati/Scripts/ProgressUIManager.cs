using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressUIManager : SingletonMonoBehaviour<ProgressUIManager>
{
    public float PlayerProgressValue => _playerProgress.value;
    public float EnemyProgressValue => _enemyProgress.value;

    [SerializeField]
    [Header("�v���C���[�̐i�s�x")]
    Slider _playerProgress;

    [SerializeField]
    [Header("�G�l�~�[�̐i�s�x")]
    Slider _enemyProgress;

    /// <summary>
    /// �v���C���[�̐i�s�x��ύX����֐�
    /// </summary>
    public float ChangePlayerProgress(float num) => _playerProgress.value += num;

    /// <summary>
    /// �G�l�~�[�̐i�s�x��ύX����֐�
    /// </summary>
    public void ChangeEnemyProgress(float num) => _enemyProgress.value += num;
}
