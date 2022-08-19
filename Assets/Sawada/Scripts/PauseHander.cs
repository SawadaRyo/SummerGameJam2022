using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PauseHander : MonoBehaviour
{
    [Header("�|�[�Y��ʂ�UI")]
    [SerializeField] GameObject[] _pauseUI = default;
    [Header("�|�[�Y��ʂ̃{�^��")]
    [SerializeField] Button[] _selectButton = default;
    public event Action<bool> PauseAction;
    // Start is called before the first frame update
    void Start()
    {
        _selectButton[0].Select();
        _pauseUI[0].SetActive(true);
        _pauseUI[1].SetActive(false);
    }

    public void Pause(bool isPause)
    {
        _pauseUI[0].SetActive(!isPause);
        _pauseUI[1].SetActive(isPause);
        PauseAction(isPause);
    }
    public void IntervalPause(bool isPause)
    {
        PauseAction(isPause);
    }
}
