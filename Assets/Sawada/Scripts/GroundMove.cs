using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [Header("Groundの動くスピード")]
    [SerializeField] float _moveSpeed = 5f;
    Player _player = default;

    float _time = 0f;
    Rigidbody2D _rb = default;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _player = GameObject.FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_player.IsWalled()) return;
        _time += Time.deltaTime;
        _rb.velocity = new Vector2(-_moveSpeed , 0f);
    }
}
