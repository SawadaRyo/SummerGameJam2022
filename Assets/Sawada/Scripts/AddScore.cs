using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : ItemBase
{
    int _score = 100;
    public override void ItemEffect()
    {
        _gameManager.SumScore(_score);
    }
}
