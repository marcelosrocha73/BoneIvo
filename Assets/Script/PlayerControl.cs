using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] Vector2 _move;
    [SerializeField] Rigidbody2D _rig;
    [SerializeField] float _speed;
    [SerializeField] float _speedAnim;
    [SerializeField] Animator _anim;
    [SerializeField] bool _isFacingRight;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _rig.velocity = new Vector2(_move.x * _speed, _rig.velocity.y);
        _speedAnim = Mathf.Abs(_rig.velocity.x);
        //_anim.SetFloat("SpeedX", 2.5f);
        _anim.SetFloat("SpeedX", _speedAnim);
        if (_move.x < 0 && _isFacingRight == false)
        {
            Flip();
        }
        else if (_move.x > 0 && _isFacingRight == true)
        {
            Flip();
        }
    }

    void Flip()
    {
        _isFacingRight = !_isFacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        // Flip collider over the x-axis
    }
    
    public void SetMove(InputAction.CallbackContext value)
    {
        // _move = value.ReadValue<Vector2>();
        Vector2 _m = value.ReadValue<Vector2>();
        _move.x = _m.x;
        _move.y = _m.y;
    }
    
}
