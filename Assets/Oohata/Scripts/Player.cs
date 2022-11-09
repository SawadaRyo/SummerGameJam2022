using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private const int _Max_jamp_count = 2;

    [SerializeField] private float _force = 250f;
    [SerializeField] Transform _centerPos = default;
    [SerializeField] LayerMask _layerMask = ~0;

    Animator _playerAnimator;
    bool _isJump = false;
    bool _isPause = false;
    int _jumpCount = 0;
    float _radius = 0.7f;
    float _distance = 0.7f;
    Rigidbody2D _rb2d;
    PauseHander _hander;

    void Awake()
    {
        _playerAnimator = GetComponent<Animator>();
        _rb2d = GetComponent<Rigidbody2D>();
        _rb2d.gravityScale = 2;
        _isJump = false;
        _hander = GameObject.FindObjectOfType<PauseHander>();
        //_playerAnimator.SetBool("isGround", true);
    }

    void OnEnable()
    {
        _hander.PauseAction += PauseRestart;
    }

    void OnDisable()
    {
        _hander.PauseAction -= PauseRestart;
    }

    void Update()
    {
        var _jumpkey = Input.GetMouseButtonDown(0);
        if (_jumpCount <= _Max_jamp_count && _jumpkey)
        {
            _isJump = true;
        }

        
    }

    void FixedUpdate()
    {
        if (IsWalled()) return;
        if (_isJump && !_isPause)
        {
            _jumpCount++;

            if (_jumpCount <= _Max_jamp_count)
            {
                _rb2d.velocity = Vector2.zero;
                _rb2d.AddForce(Vector2.up * _force);
            }
            else if (_jumpCount >= 3)
            {
                _rb2d.gravityScale = 0.5f;
                _playerAnimator.SetBool("isPalg", true);
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _playerAnimator.SetBool("isGround", true);
            _playerAnimator.SetBool("isPalg", false);
            _rb2d.gravityScale = 2;
            _jumpCount = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            _playerAnimator.SetBool("isGround", false);
        }
    }

    void PauseRestart(bool isPause)
    {
        _isPause = isPause;
        if (isPause)
        {
            _playerAnimator.enabled = false;
            _rb2d.Sleep();
        }
        else
        {
            _playerAnimator.enabled = true;
            _rb2d.WakeUp();
        }
    }
}
