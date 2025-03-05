using System.Xml;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/States/WiltedState")]
public class WiltedState : PlantState
{
    public override void EnterState(StateController controller)
    {
        Debug.Log("Entering Wilted State");
    }

    public override void UpdateState(StateController controller)
    {
        var plantAction = controller.GetComponent<PlantStateAction>();

        // If resources are replenished, transition to GrowingState
        if (plantAction.CurrentWater >= 10f && plantAction.CurrentLove >= 10f)
        {
            controller.TransitionToState(new GrowingState());
        }
        else
        {
            controller.TransitionToState(new DeadState());  // Transition to Dead if resources are too low
        }
    }

    public override void ExitState(StateController controller)
    {
        Debug.Log("Exiting Wilted State");
    }
}
