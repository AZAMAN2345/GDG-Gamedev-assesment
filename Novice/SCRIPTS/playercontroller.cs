using System;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 8f;
    [Range(0f,1f)] public float airControl = 0.5f;

    [Header("Jump")]
    public float jumpForce = 12f;
    public float coyoteTime = 0.12f;        // allow jump shortly after leaving ground
    public float jumpBufferTime = 0.12f;    // allow jump input slightly before landing
    public float variableJumpMultiplier = 0.5f; // cut jump when button released

    [Header("Ground Check")]
    public Transform groundCheck;
    public float groundCheckRadius = 0.12f;
    public LayerMask groundMask;

    [Header("Components")]
    public Rigidbody2D body;

    // runtime
    float xInput;
    bool jumpHeld;
    float coyoteTimer;
    float jumpBufferTimer;
    bool grounded;

    void Awake()
    {
        if (body == null) body = GetComponent<Rigidbody2D>();
        if (groundCheck == null) groundCheck = transform;
    }

    void Update()
    {
        // read inputs (input read in Update)
        xInput = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump")) jumpBufferTimer = jumpBufferTime;
        jumpHeld = Input.GetButton("Jump");

        // timers
        if (coyoteTimer > 0f) coyoteTimer -= Time.deltaTime;
        if (jumpBufferTimer > 0f) jumpBufferTimer -= Time.deltaTime;
    }

    void FixedUpdate()
    {
        CheckGround();

        // horizontal movement with simple smoothing/air control
        float targetX = xInput * moveSpeed;
        float lerpT = grounded ? 1f : airControl;
        float newX = Mathf.Lerp(body.linearVelocity.x, targetX, lerpT);
        Vector2 vel = body.linearVelocity;
        vel.x = newX;

        // jump: use buffer + coyote time (allow jump if grounded OR within coyote time)
        if (jumpBufferTimer > 0f && coyoteTimer > 0f)
        {
            vel.y = jumpForce;
            jumpBufferTimer = 0f;
            coyoteTimer = 0f;
        }

        body.linearVelocity = vel;

        // variable jump (cut short when player releases jump)
        if (!jumpHeld && body.linearVelocity.y > 0f)
        {
            body.linearVelocity = new Vector2(body.linearVelocity.x, body.linearVelocity.y * variableJumpMultiplier);
        }
    }

    void CheckGround()
    {
        bool wasGrounded = grounded;
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundMask);

        if (grounded)
        {
            coyoteTimer = coyoteTime;
        }
        else if (wasGrounded && !grounded)
        {
            // leaving ground — coyote timer will tick down in Update
        }
    }
}
