using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigid;
    private PlayerInput _playerInput;
    [SerializeField] private float speed;

    private void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _playerInput = GetComponent<PlayerInput>();
    }

    private void FixedUpdate()
    {
        _rigid.velocity = _playerInput.moveDir.normalized * speed;
    }
}
