using System;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{

    private PlayerMovement playerMovement;
    private Animator animator;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("onGround", playerMovement.onGroundTime > 0);
        animator.SetFloat("xSpeed", Math.Abs(rb.linearVelocityX));
        if (playerMovement.isSkidding) animator.SetTrigger("onSkid");
    }
}
