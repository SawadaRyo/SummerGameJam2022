using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallHole : MonoBehaviour
{
    [Tooltip("��l")] Vector2 _normalPos = new Vector2(0,0);
    [Tooltip("�v���C���[���W")]Vector2 _playerPos;
    void Start()
    {
        _playerPos = GameObject.Find("Player").GetComponent<Transform>().position;
    }

    void Update()
    {
        Vector2 diff = _playerPos - _normalPos;

        //if(diff.magnitude < -4.5 )
        //{
        //    SceneManager.LoadScene("GameOver");       //���ɗ�������Q�[���I�[�o�[
        //}
    }
}
