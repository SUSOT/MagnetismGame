using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigid;
    private PlayerInput _playerInput;
    [SerializeField] private float speed;

    public UnityEvent RightMoveEvent;
    public UnityEvent LeftMoveEvent;

    private void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _playerInput = GetComponent<PlayerInput>();
    }

    private void FixedUpdate()
    {
        _rigid.velocity = _playerInput.moveDir.normalized * speed;

        if(_rigid.velocity.x > 0)
        {
            RightMoveEvent?.Invoke();
        }
        else if(_rigid.velocity.x < 0)
        {
            LeftMoveEvent?.Invoke();
        }
    }
}
