using UnityEngine;

public class ChickenPower : MonoBehaviour
{
    private SpriteRenderer sr;
    private PlayerMovement playerMovement;
    private bool usedChickenJump = false;

    public Animator chickenAnimator;
    public AudioClip chickenFlap;
    public SpriteRenderer chickenSR;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        sr = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        chickenSR.flipX = sr.flipX;
        if (playerMovement.onGroundTime > 0) usedChickenJump = false;

        if (playerMovement.jumpTrigger && !usedChickenJump && playerMovement.onGroundTime < 0)
        {
            GetComponent<AudioSource>().PlayOneShot(chickenFlap);
            usedChickenJump = true;
            playerMovement.Jump();
        }
        chickenAnimator.SetBool("isFlying", usedChickenJump);
    }
}
