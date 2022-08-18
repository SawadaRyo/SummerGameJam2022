using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("ƒXƒRƒA‚Ì‡Œv")] private int _sumScore;
    [Tooltip("ˆê’â~’†‚©‚Ç‚¤‚©")] bool _isPause;
    
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
    /// ƒQ[ƒ€‚ğˆê’â~‚·‚é
    /// </summary>
    public void Pause()
    {
        if(!_isPause)
        {
            _isPause = true;
            Time.timeScale = 0;
            Debug.Log("~‚Ü‚è‚Ü‚µ‚½");
        }
        else if(_isPause)
        {
            _isPause = false;
            Time.timeScale = 1;
            Debug.Log("“®‚«‚Ü‚µ‚½");
        }
        
    }
}
