using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMove : GroundMove
{
    [SerializeField] Transform _basePos = default;
    [SerializeField] Transform _setPos = default;

    public override void FixedUpdate()
    {
        base.FixedUpdate();
        ResetPos();
    }
    void ResetPos()
    {
        float posX = this.transform.position.x;
        if (posX -_basePos.position.x <= -60)
        {
            this.transform.position = _setPos.position;
        }
    }
}
