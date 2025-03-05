using UnityEngine;
using UnityEngine.InputSystem;

public class TopDownMovement : MonoBehaviour
{
    public float speed = 2.0f;
    public float boost = 2.0f;
    public float boostCharge = 10.0f;
    private float currentBoost = 0f;
    private float currentDecay = 1.0f;

    private Vector2 directionalInput;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1.0f;
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMoveAction(InputAction.CallbackContext context)
    {
        directionalInput = context.ReadValue<Vector2>();
    }

    public void OnRoll(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        currentBoost = boost;
        currentDecay = 0.8f;
    }

    public void OnRollCharge(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        currentBoost = boostCharge;
        currentDecay = 0.9f;
    }
    public void OnInteract(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        Collider2D[] colliders = Physics2D.OverlapPointAll(new Vector2(transform.position.x, transform.position.y));
        foreach (Collider2D collider in colliders)
        {
            SimpleTrigger trigger = collider.gameObject.GetComponent<SimpleTrigger>();
            if (trigger == null) continue;
            trigger.Trigger();
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.linearVelocity = directionalInput.normalized * speed * (1f + currentBoost);
        currentBoost *= currentDecay;
    }
}
