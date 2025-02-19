using UnityEngine;
using UnityEngine.InputSystem;

public class TopDownMovement : MonoBehaviour
{
    public float speed = 2.0f;

    private Vector2 directionalInput;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMoveAction(InputAction.CallbackContext context)
    {
        directionalInput = context.ReadValue<Vector2>();
    }

    public void OnRoll(InputAction.CallbackContext context)
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = directionalInput.normalized * speed;
    }
}
