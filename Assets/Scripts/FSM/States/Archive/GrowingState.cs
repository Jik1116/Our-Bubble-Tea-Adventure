using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/States/GrowingState")]
public class GrowingState : PlantState
{
    public override void EnterState(StateController controller)
    {
        Debug.Log("Entering Growing State");
    }

    public override void UpdateState(StateController controller)
    {
        var plantAction = controller.GetComponent<PlantStateAction>();

        // If resources are insufficient, transition to WiltedState
        if (plantAction.CurrentWater < 10f || plantAction.CurrentLove < 10f)
        {
            controller.TransitionToState(new WiltedState());
        }
        else
        {
            controller.TransitionToState(new HarvestingState());  // Transition to Harvesting state once grown
        }
    }

    public override void ExitState(StateController controller)
    {
        Debug.Log("Exiting Growing State");
    }
}
