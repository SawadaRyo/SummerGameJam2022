using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : ItemBase
{
    [SerializeField] float _debufValue = 5f;
    public override void ItemEffect()
    {
        //ProgressUIManager.Instance.ChangePlayerProgress()
    }
}
