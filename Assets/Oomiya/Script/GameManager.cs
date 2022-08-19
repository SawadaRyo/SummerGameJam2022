using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Tooltip("スコアの合計")]public static int _sumScore;
    [Tooltip("一時停止中かどうか")] bool _isPause;
    [SerializeField] Text _scoreText;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "Score:" + _sumScore.ToString("D4");

        if(ProgressManager.Instance.Distance <= 0)
        {
            LoadSceneManager.Instance.OnCLickButton("GameOverScene");
        }
    }

    public void SumScore(int score)
    {
        _sumScore += score;
    }

    
}
