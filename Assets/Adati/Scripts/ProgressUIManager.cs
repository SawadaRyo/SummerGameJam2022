using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressUIManager : SingletonMonoBehaviour<ProgressUIManager>
{
    public float PlayerProgressValue => _playerProgress.value;
    public float EnemyProgressValue => _enemyProgress.value;

    [SerializeField]
    [Header("プレイヤーの進行度")]
    Slider _playerProgress;

    [SerializeField]
    [Header("エネミーの進行度")]
    Slider _enemyProgress;

    /// <summary>
    /// プレイヤーの進行度を変更する関数
    /// </summary>
    public float ChangePlayerProgress(float num) => _playerProgress.value += num;

    /// <summary>
    /// エネミーの進行度を変更する関数
    /// </summary>
    public void ChangeEnemyProgress(float num) => _enemyProgress.value += num;
}
