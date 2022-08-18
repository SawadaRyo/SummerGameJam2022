using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    //protected GameManager _gameManager = default;
    public abstract void ItemEffect();

    private void Start()
    {
        //_gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            ItemEffect();
            Destroy(gameObject);
        }
    }
}
