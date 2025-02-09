using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    [Header("Run")]
    public float forwardSpeed = 10.0f;
    public float maxSpeedX = 20.0f;
    public float brakeBoost = 5.0f;

    [Header("Jump")]
    public float jumpForce = 400.0f;
    public float jumpGravityMult = 0.7f;
    public float coyoteTime = 1.0f;

    [Header("Timers")]
    [SerializeField] private float jumpPressedTime;
    [SerializeField] private float onGroundTime;

    private Vector2 directionalInput;
    private Rigidbody2D rb;

    private Vector2 force = Vector2.zero;
    private float initalGravityScale;

    private bool jumpTrigger;
    private bool jumpCutTrigger;

    [Header("Checks")]
    [SerializeField] private Transform _groundCheckPoint;
    [SerializeField] private Vector2 _groundCheckSize = new Vector2(0.49f, 0.03f);
    [Header("Layers & Tags")]
    [SerializeField] private LayerMask _groundLayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initalGravityScale = rb.gravityScale;
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
        jumpPressedTime -= deltaTime;

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

        if (Physics2D.OverlapBox(_groundCheckPoint.position, _groundCheckSize, 0, _groundLayer))
        {
            onGroundTime = coyoteTime;
        }

        if (jumpTrigger && onGroundTime > 0.0f)
        {
            jumpPressedTime = onGroundTime = 0;

            // Give player lower gravity when jump is held
            rb.gravityScale = initalGravityScale * jumpGravityMult;

            if (rb.linearVelocityY < 0)
            {
                rb.linearVelocityY = 0.0f;
            }

            rb.AddForce(jumpForce * Vector2.up);
        }
        if (jumpCutTrigger)
        {
            // Revert gravity to original state for a jump cut
            rb.gravityScale = initalGravityScale;
        }

        jumpTrigger = false;
        jumpCutTrigger = false;
    }

    void OnDrawGizmos()
    {
        // Gizmos.DrawLine(transform.position, transform.position + new Vector3(directionalInput.x, directionalInput.y, 0.0f));
        Gizmos.DrawLine(transform.position, transform.position + force.x * Vector3.right);
        Gizmos.DrawCube(_groundCheckPoint.position, _groundCheckSize);
    }
}
