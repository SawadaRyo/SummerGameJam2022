using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �G�l�~�[���X���[�Y�ɓ������X�N���v�g
/// </summary>
public class EnemyController: MonoBehaviour
{
    [SerializeField]
    [Header("�X�s�[�h")]
    float _speed = 10f;

    Vector3 _enemyTargetPos;
    GameObject _player;

    const float OFFSET_TARGET_POS = 0.1f;
    const float OFFSET_DISTANCE = 100;
    const string PLAYER_TAG = "Player";

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag(PLAYER_TAG);
        StartCoroutine(FirstEnemyMove());
    }

    void Update()
    {
        _enemyTargetPos = new Vector3(-ProgressManager.Instance.Distance * OFFSET_DISTANCE + _player.transform.position.x, 0f, 0f);

        if (ProgressManager.Instance.StartTime <= TimeManager.Instance.Timer)
        {
            EnemyMove();
        }
    }

    /// <summary>�ŏ������ʂ̓�����������</summary>
    IEnumerator FirstEnemyMove()
    {
        while(true)
        {
            transform.position += new Vector3(-0.01f,0f,0f);
            yield return null;
            if(ProgressManager.Instance.StartTime <= TimeManager.Instance.Timer)
            {
                StopAllCoroutines();
            }
        }
    }

    /// <summary>�G�l�~�[�𓮂���</summary>
    void EnemyMove()
    {
        bool leftRange = transform.position.x + OFFSET_TARGET_POS <= _enemyTargetPos.x;
        bool rightRange = transform.position.x - OFFSET_TARGET_POS >= _enemyTargetPos.x;

        if (leftRange || rightRange)
        {
            transform.position += (_enemyTargetPos - transform.position).normalized / _speed;
        }
        else
        {
            transform.position += (_enemyTargetPos - transform.position) / _speed;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(TryGetComponent(out Transform transform))
        {
            //�v���C���[��HP�����炷�H�������Ăяo��
            Debug.Log("�v���C���[�ɓ�������");
        }
    }
}
