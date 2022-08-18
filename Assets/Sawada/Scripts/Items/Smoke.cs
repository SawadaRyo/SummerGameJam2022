using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : ItemBase
{
    [Header("Enemy‚ª‰“‚Ì‚­‹——£")]
    [SerializeField] float _bufValue = 1f;
    public override void ItemEffect()
    {
        ProgressUIManager.Instance.ChangeEnemyProgress(-_bufValue);
    }
}
