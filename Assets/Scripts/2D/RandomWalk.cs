using UnityEngine;

public class RandomWalk : MonoBehaviour
{
    private Rigidbody2D rb;

    public float walkTiming = 1.0f;

    private float lastWalk = 0.0f;
    private Vector2 direction;
    void Start()
    {
        lastWalk = Random.Range(0f, walkTiming);
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        lastWalk -= Time.fixedDeltaTime;
        if (lastWalk < 0.0f)
        {
            lastWalk = walkTiming;
            float rand_angle = Random.Range(0f, 2 * 3.14f);
            direction = new Vector3(Mathf.Cos(rand_angle), Mathf.Sin(rand_angle), 0f);
        }
        rb.linearVelocity = direction;
    }
}
