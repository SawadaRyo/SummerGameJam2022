using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : ItemBase
{
    [Header("���_��")]
    [SerializeField]int _score = 100;
    public override void ItemEffect()
    {
        _gameManager.SumScore(_score);
    }
}
