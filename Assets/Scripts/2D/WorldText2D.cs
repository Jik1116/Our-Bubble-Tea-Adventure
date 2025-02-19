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

    public void Trigger()
    {
        if (lastTriggerTime < 0)
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSource.clip);
        }
        lastTriggerTime = triggerTime;
    }
}
