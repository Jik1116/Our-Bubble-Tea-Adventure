using UnityEngine;

public class ChickenPower : MonoBehaviour
{
    private SpriteRenderer sr;
    private PlayerMovement playerMovement;
    private bool usedChickenJump = false;

    public GameObject chicken;
    public Animator chickenAnimator;
    public AudioSource chickenAudio;
    public AudioClip chickenFlap;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (playerMovement.onGroundTime > 0) usedChickenJump = false;

        if (playerMovement.jumpTrigger && !usedChickenJump && playerMovement.onGroundTime < 0)
        {
            chickenAudio.PlayOneShot(chickenFlap);
            usedChickenJump = true;
            playerMovement.Jump();
        }
        chickenAnimator.SetBool("isFlying", usedChickenJump);
    }
}
