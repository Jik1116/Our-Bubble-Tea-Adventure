using UnityEngine;

public class ChickenPower : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private bool usedChickenJump = false;

    public Animator chickenAnimator;
    public AudioClip chickenFlap;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }


    void Update()
    {
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
