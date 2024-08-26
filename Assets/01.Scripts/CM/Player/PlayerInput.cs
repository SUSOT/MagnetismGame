using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector2 moveDir { get; private set; }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        moveDir = new Vector2(h, 0);
    }
}
