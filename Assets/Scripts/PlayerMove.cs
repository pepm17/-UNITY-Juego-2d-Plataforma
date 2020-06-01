using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float runSpeed = 2;
    private float jumpSpeed = 3;
    
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            this.rb2d.velocity = new Vector2(runSpeed, this.rb2d.velocity.y);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            this.rb2d.velocity = new Vector2(-runSpeed, this.rb2d.velocity.y);
        }
        else
        {
            this.rb2d.velocity = new Vector2(0, this.rb2d.velocity.y);
        }
        if (Input.GetKey("space") && CheckGround.isGrounded)
        {
            this.rb2d.velocity = new Vector2(this.rb2d.velocity.x, this.jumpSpeed);
        }
    }
}
