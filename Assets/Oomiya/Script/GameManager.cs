using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("スコアの合計")] static int _sumScore;
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

    
}
