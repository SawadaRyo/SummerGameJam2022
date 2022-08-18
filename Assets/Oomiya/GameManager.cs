using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("�X�R�A�̍��v")] private int _sumScore;
    [Tooltip("�ꎞ��~�����ǂ���")] bool _isPause;
    
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
    /// �Q�[�����ꎞ��~����
    /// </summary>
    public void Pause()
    {
        if(!_isPause)
        {
            _isPause = true;
            Time.timeScale = 0;
            Debug.Log("�~�܂�܂���");
        }
        else if(_isPause)
        {
            _isPause = false;
            Time.timeScale = 1;
            Debug.Log("�����܂���");
        }
        
    }
}
