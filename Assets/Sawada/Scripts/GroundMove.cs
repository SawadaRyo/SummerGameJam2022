using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    [Header("Groundの動くスピード")]
    [SerializeField] float _moveSpeed = 5f;
    

    float _time = 0f;
    float _beforeSpeed = 0f;
    Rigidbody2D _rb = default;
    Player _player = default;
    PauseHander _hander = default;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _player = GameObject.FindObjectOfType<Player>();
        _hander = GameObject.FindObjectOfType<PauseHander>();
    }
    private void OnEnable()
    {
        _hander.PauseAction += PauseRestart;
    }
    private void OnDisable()
    {
        _hander.PauseAction -= PauseRestart;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_player.IsWalled()) return;
        _time += Time.deltaTime;
        _rb.velocity = new Vector2(-_moveSpeed, 0f);
    }
    

    void PauseRestart(bool isPause)
    {
        if(isPause)
        {
            _beforeSpeed = _moveSpeed;
            _moveSpeed = 0f;
        }
        else
        {
            _moveSpeed = _beforeSpeed;
        }
    }
}
