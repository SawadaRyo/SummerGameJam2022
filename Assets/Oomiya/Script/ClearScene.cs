using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearScene : MonoBehaviour
{
    [SerializeField] Text _scoreText;
    private int _score;
    void Start()
    {
        _score = GameManager._sumScore;
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "Score:" + _score.ToString("D4");
    }
}
