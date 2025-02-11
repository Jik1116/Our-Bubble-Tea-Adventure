using UnityEngine;

public class GetChickenPower : MonoBehaviour
{
    public float playerHeadOffset = 0.1f;
    public AudioClip chickenFlap;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSource.clip);

            GameObject player = collider.gameObject;
            ChickenPower chickenPower = player.AddComponent<ChickenPower>();
            chickenPower.chickenAnimator = GetComponent<Animator>();
            chickenPower.chickenFlap = chickenFlap;
            chickenPower.chickenSR = GetComponent<SpriteRenderer>();

            transform.parent.SetParent(player.transform);
            float offset = (player.GetComponents<ChickenPower>().Length) * playerHeadOffset;
            // 3 is the players local scale, currently hardcoded due to animation changing the player scale
            transform.parent.position = player.transform.position + 3 * new Vector3(0, offset, 0);
            enabled = false;
        }
    }
}
