using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private const int _Max_jamp_count = 2;

    [SerializeField]
    private float _force = 250f;

    private int _jumpcount = 0;
    private bool _isJump;
    Rigidbody2D _rb2d;
    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _rb2d.gravityScale = 2;
        _isJump = false;
    }


    void Update()
    {
        var _jumpkey = Input.GetKeyDown(KeyCode.Space);
        if (_jumpcount <= _Max_jamp_count && _jumpkey)
        {
            _isJump = true;
        }
    }

    void FixedUpdate()
    {
        if (_isJump)
        {
            _jumpcount++;

            if (_jumpcount  <= _Max_jamp_count)
            {
                _rb2d.velocity = Vector2.zero;
                _rb2d.AddForce(Vector2.up * _force);
            }
            else if (_jumpcount >= 3)
            {
                _rb2d.gravityScale = 0.5f;
            }

            _isJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("cube"))
        {
            _rb2d.gravityScale = 2;
            _jumpcount = 0;
        }

    }
}
