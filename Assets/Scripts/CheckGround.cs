using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    private bool isGrounded;

    public bool IsGrounded { get => isGrounded; set => isGrounded = value; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IsGrounded = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        IsGrounded = false;
    }
}
