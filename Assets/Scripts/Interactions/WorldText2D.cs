using UnityEngine;

public class WorldText2D : MonoBehaviour
{
    public float triggerTime = 1.0f;
    [SerializeField] private CanvasGroup canvasGroup;

    [Header("Timers")]
    public float lastTriggerTime;

    // Update is called once per frame
    void Update()
    {
        lastTriggerTime -= Time.deltaTime;
        canvasGroup.alpha = lastTriggerTime > 0 ? 1.0f : 0.0f;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) Trigger();
    }

    public void Trigger()
    {
        lastTriggerTime = triggerTime;
    }
}
