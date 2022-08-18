using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallHole : MonoBehaviour
{
    Vector2 _normalPos = new Vector2(0,0);
    Vector2 _playerPos;
    void Start()
    {
        _playerPos = GetComponent<Transform>().position;
    }

    void Update()
    {
        
    }
}
