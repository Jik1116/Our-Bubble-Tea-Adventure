using UnityEngine;

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

    void Update()
    {
        directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = directionalInput.normalized * speed;
    }
}
