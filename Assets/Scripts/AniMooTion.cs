using System;
using UnityEngine;

public class AniMooTion : MonoBehaviour
{

    private MooVement mooVement;
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;

    void Start()
    {
        mooVement = GetComponent<MooVement>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("xSpeed", Math.Abs(rb.linearVelocityX));
        if (rb.linearVelocityX != 0) sr.flipX = mooVement.direction < 0.0f;
    }
}
