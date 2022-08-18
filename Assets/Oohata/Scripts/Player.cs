using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private const int _Max_jamp_count = 2;

    [SerializeField] private float _force = 250f;
    [SerializeField] Transform _centerPos = default;
    [SerializeField] LayerMask _layerMask = ~0;

    bool _isJump;
    int _jumpCount = 0;
    float _radius = 0.7f;
    float _distance = 0.7f;

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
        if (_jumpCount <= _Max_jamp_count && _jumpkey)
        {
            _isJump = true;
        }
    }

    void FixedUpdate()
    {
        if (_isJump)
        {
            _jumpCount++;

            if (_jumpCount  <= _Max_jamp_count)
            {
                _rb2d.velocity = Vector2.zero;
                _rb2d.AddForce(Vector2.up * _force);
            }
            else if (_jumpCount >= 3)
            {
                _rb2d.gravityScale = 0.5f;
            }

            _isJump = false;
        }
    }

    public bool IsWalled()
    {
        Vector2 center = _centerPos.position;
        bool onWall = Physics2D.CircleCast(center, _radius, Vector2.right, _distance, _layerMask);
        return onWall;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _rb2d.gravityScale = 2;
            _jumpCount = 0;
        }
    }
}
