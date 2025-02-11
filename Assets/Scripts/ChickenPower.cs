using UnityEngine;

public class ChickenPower : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private bool usedChickenJump = false;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }


    void Update()
    {
        if (playerMovement.onGroundTime > 0) usedChickenJump = false;

        if (playerMovement.jumpTrigger && !usedChickenJump && playerMovement.onGroundTime < 0)
        {
            usedChickenJump = true;
            playerMovement.Jump();
        }
    }
}
