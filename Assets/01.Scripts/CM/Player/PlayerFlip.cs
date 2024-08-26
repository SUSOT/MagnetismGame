using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    private SpriteRenderer _sprite;

    private void Start()
    {
        _sprite = GetComponentInChildren<SpriteRenderer>();
    }

    public void RigidMove()
    {
        _sprite.flipX = true;
    }

    public void LeftMove()
    {
        _sprite.flipX = false; 
    }
}
