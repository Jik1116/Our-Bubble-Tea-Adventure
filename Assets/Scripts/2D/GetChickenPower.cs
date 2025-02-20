using UnityEngine;
using UnityEngine.Events;

public class GetChickenPower : MonoBehaviour
{
    public float playerHeadOffset = 0.1f;
    public AudioClip chickenFlap;

    private bool hasTrigger = false;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (hasTrigger) return;
        if (collider.gameObject.CompareTag("Player"))
        {
            GameObject player = collider.gameObject;
            int offset = player.GetComponents<ChickenPower>().Length;

            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.pitch = 1f + (offset * 0.2f);
            audioSource.PlayOneShot(audioSource.clip);

            ChickenPower chickenPower = player.AddComponent<ChickenPower>();
            chickenPower.chicken = this.gameObject;
            chickenPower.chickenAnimator = GetComponent<Animator>();
            chickenPower.chickenAudio = GetComponent<AudioSource>();
            chickenPower.chickenFlap = chickenFlap;

            transform.parent.SetParent(player.transform);
            float pos_offset = (offset + 1) * playerHeadOffset;
            // 3 is the players local scale, currently hardcoded due to animation changing the player scale
            transform.parent.position = player.transform.position + 3 * new Vector3(0, pos_offset, 0);
            enabled = false;
            hasTrigger = true;
        }
    }
}
