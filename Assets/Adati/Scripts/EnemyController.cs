using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController: MonoBehaviour
{
    const float OFFSET = 10;

    Vector3 _vector3;
    GameObject _player;
    const string PLAYER_TAG = "Player";

    //void Start()
    //{
    //    _player = GameObject.FindGameObjectWithTag(PLAYER_TAG);
    //}

    //void Update()
    //{
    //    _vector3 = new Vector3(-ProgressManager.Instance.Distance * 100 - _player.transform.position.x, 0f, 0f);
    //    transform.position = _vector3;
    //}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(TryGetComponent(out Rigidbody2D rb))
        {
            //Player‚ÌHP‚ğŒ¸‚ç‚·Hˆ—‚ğ‘‚­
        }
    }
}
