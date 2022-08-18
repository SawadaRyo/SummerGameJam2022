using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : ItemBase
{
    float _offSet = 100f;
    public override void ItemEffect()
    {
        ProgressUIManager.Instance.ChangeEnemyProgress(-(Time.deltaTime / _offSet));
    }
}
