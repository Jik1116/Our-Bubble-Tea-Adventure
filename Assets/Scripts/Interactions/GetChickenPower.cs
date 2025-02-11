using UnityEngine;

public class GetChickenPower : MonoBehaviour
{
    public float playerHeadOffset = 0.1f;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(audioSource.clip);

            GameObject player = collider.gameObject;
            player.AddComponent<ChickenPower>();
            transform.SetParent(player.transform);
            // 3 is the players local scale, currently hardcoded due to animation changing the player scale
            transform.position = player.transform.position + 3 * new Vector3(0, playerHeadOffset, 0);
            enabled = false;
        }
    }
}
