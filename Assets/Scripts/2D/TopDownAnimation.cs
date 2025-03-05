using System;
using UnityEngine;

public class TopDownAnimation : MonoBehaviour
{

    // private PlayerMovement playerMovement;
    private Animator animator;
    private Rigidbody2D rb;
    // private SpriteRenderer sr;

    void Start()
    {
        // playerMovement = GetComponent<PlayerMovement>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        // sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        animator.SetFloat("horizontalMovement", rb.linearVelocityX);
        animator.SetFloat("verticalMovement", rb.linearVelocityY);
        // animator.SetBool("onSkid", playerMovement.isSkidding);
        // if (playerMovement.xAxis != 0)
        // {
        //     Vector3 angles = transform.localEulerAngles;
        //     angles.y = (playerMovement.xAxis < 0.0f) ? 180f : 0f;
        //     transform.localEulerAngles = angles;
        // }
    }
}