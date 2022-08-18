using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    protected GameManager _gameManager = default;
    Renderer _renderer = default;
    Collider2D _collider;
    public abstract void ItemEffect();

    private void Start()
    {
        _gameManager = GameObject.FindObjectOfType<GameManager>();
        _renderer = GetComponent<Renderer>();
        _collider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            ItemEffect();
            Destroy();
        }
    }

    void Destroy()
    {
        _renderer.enabled = false;
        _collider.enabled = false;
    }
}
