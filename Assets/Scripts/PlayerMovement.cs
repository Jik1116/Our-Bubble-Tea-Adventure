using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Run")]
    public float forwardSpeed = 10.0f;
    public float maxSpeedX = 20.0f;
    public float brakeBoost = 5.0f;

    [Header("Jump")]
    public float jumpForce = 10.0f;
    public float gravityScale = 3.0f;
    public float jumpGravityMult = 0.7f;
    public float coyoteTime = 1.0f;

    [Header("Timers")]
    public float onGroundTime;

    [Header("Checks")]
    [SerializeField] private float _groundCheckOffset = 0.27f;
    [SerializeField] private Vector2 _groundCheckSize = new Vector2(0.33f, 0.03f);
    [Header("Layers & Tags")]
    [SerializeField] private LayerMask _groundLayer;

    [Header("For External Scripts")]
    public bool isSkidding;
    public Vector2 directionalInput;
    public bool jumpTrigger;
    public bool jumpCutTrigger;

    [Header("Debug")]
    public bool showForce;
    public bool showGroundCheck;

    private Rigidbody2D rb;
    private Vector2 appliedForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0.0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpTrigger = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            jumpCutTrigger = true;
        }

    }

    void FixedUpdate()
    {
        float deltaTime = Time.fixedDeltaTime;
        onGroundTime -= deltaTime;

        if (rb.linearVelocityY < 0.0f)
        {
            rb.gravityScale = gravityScale;
        }

        // Scale force based on how close we are to max speed
        float targetSpeed = directionalInput.x * maxSpeedX;
        targetSpeed = targetSpeed - rb.linearVelocityX;
        float force = forwardSpeed * (targetSpeed / maxSpeedX);

        isSkidding = false;
        if (Math.Sign(directionalInput.x) != Math.Sign(rb.linearVelocityX))
        {
            // Apply a brake force if deccelerating
            force = force * brakeBoost;
            if (force != 0.0f && Math.Abs(rb.linearVelocityX) > (maxSpeedX * 0.4f))
            {
                isSkidding = true;
            }
        }
        else if (targetSpeed != 0 && (rb.linearVelocityX / targetSpeed) > 1.0f)
        {
            // Don't slow player down if they managed to conserve momentum
            force = 0.0f;
        }

        rb.AddForce(force * Vector2.right, ForceMode2D.Force);
        appliedForce.x = force;

        if (Physics2D.OverlapBox(_groundCheckPosition(), _groundCheckSize, 0, _groundLayer))
        {
            onGroundTime = coyoteTime;
        }

        if (jumpTrigger && onGroundTime > 0.0f)
        {
            Jump();
        }
        if (jumpCutTrigger)
        {
            // Revert gravity to original state for a jump cut
            rb.gravityScale = gravityScale;
        }

        jumpTrigger = false;
        jumpCutTrigger = false;
    }

    public void Jump()
    {
        onGroundTime = 0;

        // Give player lower gravity when jump is held
        rb.gravityScale = gravityScale * jumpGravityMult;

        if (rb.linearVelocityY < 0)
        {
            rb.linearVelocityY = 0.0f;
        }

        rb.AddForce(jumpForce * Vector2.up, ForceMode2D.Impulse);
        appliedForce.y = jumpForce;
    }

    void OnDrawGizmos()
    {
        // Gizmos.DrawLine(transform.position, transform.position + new Vector3(directionalInput.x, directionalInput.y, 0.0f));
        if (showForce) Gizmos.DrawLine(transform.position, transform.position + appliedForce.x * Vector3.right);
        if (showGroundCheck) Gizmos.DrawCube(_groundCheckPosition(), _groundCheckSize);
    }

    Vector3 _groundCheckPosition()
    {
        return transform.position + _groundCheckOffset * Vector3.down;
    }
}
