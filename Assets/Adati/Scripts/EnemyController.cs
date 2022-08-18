using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController: MonoBehaviour
{

    Vector3 _enemyPos;
    GameObject _player;

    const float OFFSET = 100;
    const string PLAYER_TAG = "Player";

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag(PLAYER_TAG);
    }

    void Update()
    {
        if(ProgressManager.Instance.StartTime >= TimeManager.Instance.Timer)
        {
            _enemyPos = new Vector3(-ProgressManager.Instance.Distance * OFFSET + _player.transform.position.x, 0f, 0f);
            transform.position = _enemyPos;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(TryGetComponent(out Transform transform))
        {
            //�v���C���[��HP�����炷�H����������
            Debug.Log("�v���C���[�ɓ�������");
        }
    }
}
