using System;
using UnityEngine;

public class AniMooTion : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("xSpeed", Math.Abs(rb.linearVelocityX));
    }
}
