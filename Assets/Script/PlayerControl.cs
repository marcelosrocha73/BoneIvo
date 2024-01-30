using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] Vector2 _move;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _speed;
    [SerializeField] float _speedAnim;
    [SerializeField] Animator _anim;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _rb.velocity = new Vector2(_move.x, _rb.velocity.y);
        _anim.SetFloat("SpeedX", 2.5f);
    }
    public void SetMove(InputAction.CallbackContext value)
    {
        // _move = value.ReadValue<Vector2>();
        Vector2 _m = value.ReadValue<Vector2>();
        _move.x = _m.x;
        _move.y = _m.y;
    }
    
}
