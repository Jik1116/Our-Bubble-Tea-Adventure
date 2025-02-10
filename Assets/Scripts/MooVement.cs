using System;
using UnityEngine;

public class MooVement : MonoBehaviour
{

    public float leftOffset = 1.0f;
    public float rightOffset = 1.0f;

    public float lingerTime = 1.0f;
    public float walkSpeed = 1.0f;

    public float lingerTimeLeft;
    public float direction = 1.0f;

    private Rigidbody2D rb;
    private float leftPos;
    private float rightPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float currentPos = transform.position.x;
        leftPos = currentPos - leftOffset;
        rightPos = currentPos + rightOffset;
    }

    // Update is called once per frame
    void Update()
    {
        lingerTimeLeft -= Time.deltaTime;

        float currentPos = transform.position.x;

        if (currentPos < leftPos || currentPos > rightPos)
        {
            Vector3 pos = transform.position;
            pos.x = Math.Clamp(currentPos, leftPos, rightPos);
            transform.position = pos;
            lingerTimeLeft = lingerTime;
            direction = -direction;
            rb.linearVelocityX = 0.0f;
        }

        if (lingerTimeLeft >= 0) return;

        rb.linearVelocityX = direction * walkSpeed;
    }

    void OnDrawGizmos()
    {
        if (rb != null)
        {
            Vector3 pos = transform.position;
            pos.x = leftPos;
            Gizmos.DrawLine(transform.position, pos);
            pos.x = rightPos;
            Gizmos.DrawLine(transform.position, pos);
        }
        else
        {
            Gizmos.DrawLine(transform.position, transform.position + leftOffset * Vector3.left);
            Gizmos.DrawLine(transform.position, transform.position + rightOffset * Vector3.right);
        }
    }
}
