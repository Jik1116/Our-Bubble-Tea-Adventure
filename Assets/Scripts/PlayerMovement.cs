using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 10.0f;
    public float maxSpeedX = 20.0f;
    public float brakeBoost = 5.0f;

    public float jumpForce = 400.0f;
    public float jumpGravityMult = 0.7f;

    private float jumpPressedTime;
    private float onGroundTime;

    private Vector2 directionalInput;
    private Rigidbody2D rb;

    private Vector2 force = Vector2.zero;
    private float initalGravityScale;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initalGravityScale = rb.gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnJumpInputDown();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            OnJumpInputUp();
        }

    }

    void FixedUpdate()
    {
        float deltaTime = Time.fixedDeltaTime;
        onGroundTime += deltaTime;
        jumpPressedTime += deltaTime;

        if (rb.linearVelocityY < 0.0f)
        {
            rb.gravityScale = initalGravityScale;
        }

        // Scale force based on how close we are to max speed
        float targetSpeed = directionalInput.x * maxSpeedX;
        targetSpeed = targetSpeed - rb.linearVelocityX;
        float force = forwardSpeed * (targetSpeed / maxSpeedX);

        if (Math.Sign(directionalInput.x) != Math.Sign(rb.linearVelocityX))
        {
            // Apply a brake force if deccelerating
            force = force * brakeBoost;
        }
        else if (targetSpeed != 0 && (rb.linearVelocityX / targetSpeed) > 1.0f)
        {
            // Don't slow player down if they managed to conserve momentum
            force = 0.0f;
        }

        rb.AddForce(force * Vector2.right);
        this.force.x = force;
    }

    void OnJumpInputUp()
    {
        rb.gravityScale = initalGravityScale;
    }

    void OnJumpInputDown()
    {
        jumpPressedTime = onGroundTime = 0;

        rb.gravityScale = initalGravityScale * jumpGravityMult;
        rb.AddForce(jumpForce * Vector2.up);
    }

    void OnDrawGizmos()
    {
        // Gizmos.DrawLine(transform.position, transform.position + new Vector3(directionalInput.x, directionalInput.y, 0.0f));
        Gizmos.DrawLine(transform.position, transform.position + force.x * Vector3.right);
    }
}
