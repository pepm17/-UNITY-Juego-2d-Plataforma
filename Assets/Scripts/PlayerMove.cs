using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private readonly float runSpeed = 2;
    private readonly float jumpSpeed = 4;

    private readonly bool betterJump = true;
    private readonly float fallMultiplier = 0.5f;
    private readonly float lowJumpMultiplier = 1f;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private CheckGround cG;
    
    Rigidbody2D rb2d;

    void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
        this.cG = gameObject.AddComponent<CheckGround>();
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            this.rb2d.velocity = new Vector2(runSpeed, this.rb2d.velocity.y);
            this.spriteRenderer.flipX = false;
            this.animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            this.rb2d.velocity = new Vector2(-runSpeed, this.rb2d.velocity.y);
            this.spriteRenderer.flipX = true;
            this.animator.SetBool("Run", true);
        }
        else
        {
            this.rb2d.velocity = new Vector2(0, this.rb2d.velocity.y);
            this.animator.SetBool("Run", false);
        }
        if (Input.GetKey("space") && this.cG.IsGrounded)
        {
            this.rb2d.velocity = new Vector2(this.rb2d.velocity.x, this.jumpSpeed);
        }
        if (!this.cG.IsGrounded)
        {
            this.animator.SetBool("Jump", true);
            this.animator.SetBool("Run", false);
        }
        else
        {
            this.animator.SetBool("Jump", false);
        }
        if (this.betterJump)
        {
            if (this.rb2d.velocity.y < 0)
            {
                this.rb2d.velocity += Vector2.up * Physics2D.gravity.y * (this.fallMultiplier) * Time.deltaTime;
            }
            if (this.rb2d.velocity.y > 0 && !Input.GetKey("space"))
            {
                this.rb2d.velocity += Vector2.up * Physics2D.gravity.y * (this.lowJumpMultiplier) * Time.deltaTime;
            }
        }
    }
}
