using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/States/HarvestingState")]
public class HarvestingState : PlantState
{
    public override void EnterState(StateController controller)
    {
        Debug.Log("Entering Harvesting State");

        // Update the plant's status to reflect that it's ready for harvesting
        var plantAction = controller.GetComponent<PlantStateAction>();
        plantAction.CurrentWater = 0f;  // Water is depleted after harvest
        plantAction.CurrentLove = 0f;   // Love resets to 0 after harvest

        // You could also trigger an animation or particle effect here
        // For example, play a harvesting animation
        controller.gameObject.GetComponent<Animator>().SetTrigger("Harvest");

        // Optionally, if you have other setup actions to run when harvesting, you can call them here.
    }

    public override void UpdateState(StateController controller)
    {
        // The plant stays in the harvesting state until the player interacts to reset or replant it

        // Example: If a player presses a button to reset, move to a ReplantState (this would need to be a different state)
        if (controller.GetComponent<PlantStateAction>().CurrentWater == 0f && controller.GetComponent<PlantStateAction>().CurrentLove == 0f)
        {
            // For simplicity, we'll assume the next transition is to a ReplantingState
            controller.TransitionToState(new PlantingState());
        }
    }

    public override void ExitState(StateController controller)
    {
        Debug.Log("Exiting Harvesting State");

        // Clean up or reset any variables if needed
    }
}
