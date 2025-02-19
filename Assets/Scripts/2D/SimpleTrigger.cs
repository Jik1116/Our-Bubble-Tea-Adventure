using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : MonoBehaviour
{
    public UnityEvent triggerFunc;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player")) triggerFunc.Invoke();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) triggerFunc.Invoke();
    }

}
