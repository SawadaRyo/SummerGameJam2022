using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : ItemBase
{
    [Header("Enmey‚ª‹ß‚Ã‚­‹——£")]
    [SerializeField] float _debufValue = 1f;
    public override void ItemEffect()
    {
        ProgressUIManager.Instance.ChangeEnemyProgress(_debufValue);
    }
}
