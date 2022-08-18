using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : SingletonMonoBehaviour<TimeManager>
{
    public float Timer => _timer;

    float _timer;

    void Update()
    {
        _timer += UnityEngine.Time.deltaTime;
    }
}
