using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("�X�R�A�̍��v")] static int _sumScore;
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

    
}
