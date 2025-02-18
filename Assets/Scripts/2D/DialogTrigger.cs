using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (!collider.gameObject.CompareTag("Player")) return;

        GetComponent<DialogController>().Trigger();
    }
}
