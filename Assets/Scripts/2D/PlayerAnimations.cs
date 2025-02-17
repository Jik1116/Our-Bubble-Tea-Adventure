using System;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{

    private PlayerMovement playerMovement;
    private Animator animator;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        animator.SetBool("onGround", playerMovement.onGroundTime > 0);
        animator.SetFloat("xSpeed", Math.Abs(rb.linearVelocityX));
        animator.SetBool("onSkid", playerMovement.isSkidding);
        if (playerMovement.directionalInput.x != 0)
        {
            Vector3 angles = transform.localEulerAngles;
            angles.y = (playerMovement.directionalInput.x < 0.0f) ? 180f : 0f;
            transform.localEulerAngles = angles;
        }
    }
}