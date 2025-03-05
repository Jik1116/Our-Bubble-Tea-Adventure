using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/States/PlantingState")]
public class PlantingState : PlantState
{
    public override void EnterState(StateController controller)
    {
        Debug.Log("Entering Planting State");

        // Reset water and love to initial values when the plant is planted
        var plantAction = controller.GetComponent<PlantStateAction>();
        plantAction.CurrentWater = 10f;  // Initial water level (you can adjust this value)
        plantAction.CurrentLove = 10f;   // Initial love level (you can adjust this value)

        // Trigger planting animation or reset the plant's growth stage
        controller.gameObject.GetComponent<Animator>().SetTrigger("Plant");

        // You can reset the plant's growth stage here (e.g., set it to sprout state)
        // You may also want to reset any other parameters such as age, size, etc.
        // For example, if you have a growth stage variable:
        plantAction.CurrentGrowthStage = GrowthStage.Sprout; // Reset to the sprout stage or initial stage
    }

    public override void UpdateState(StateController controller)
    {
        // Add logic here if the plant should transition to another state
        // After planting, you can automatically transition to the growing state once it's ready to grow
        if (controller.GetComponent<PlantStateAction>().CurrentGrowthStage == GrowthStage.Sprout)
        {
            // Example: Automatically transition to the GrowingState when the plant starts sprouting
            controller.TransitionToState(new GrowingState());
        }
    }

    public override void ExitState(StateController controller)
    {
        Debug.Log("Exiting Planting State");

        // Reset or clean up anything if needed, though there's typically little to clean up after planting
    }
}
