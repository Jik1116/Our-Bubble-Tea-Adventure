using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 10.0f;
    public float maxSpeedX = 20.0f;
    public float brakeBoost = 1.5f;

    private Vector2 directionalInput;
    private Rigidbody2D rb;

    private Vector2 force = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
        // Scale force based on how close we are to max speed
        float targetSpeed = directionalInput.x * maxSpeedX;
        targetSpeed = targetSpeed - rb.linearVelocityX;
        float force = forwardSpeed * (targetSpeed / maxSpeedX);
        if (Math.Sign(directionalInput.x) != Math.Sign(rb.linearVelocityX))
        {
            force = force * brakeBoost;
        }

        rb.AddForce(force * Vector2.right, ForceMode2D.Force);
        this.force.x = force;
    }

    void OnJumpInputUp()
    {

    }

    void OnJumpInputDown()
    {

    }

    void OnDrawGizmos()
    {
        // Gizmos.DrawLine(transform.position, transform.position + new Vector3(directionalInput.x, directionalInput.y, 0.0f));
        Gizmos.DrawLine(transform.position, transform.position + force.x * Vector3.right);
    }
}
