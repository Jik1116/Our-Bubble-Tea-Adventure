using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/States/SproutingState")]
public class SproutingState : PlantState
{
    public override void EnterState(StateController controller)
    {
        Debug.Log("Entering Sprouting State");
        // Initialize setup actions for the sprouting state
        controller.gameObject.GetComponent<PlantStateAction>().CurrentWater = 10f;
        controller.gameObject.GetComponent<PlantStateAction>().CurrentLove = 10f;
    }

    public override void UpdateState(StateController controller)
    {
        var plantAction = controller.GetComponent<PlantStateAction>();

        // If not enough resources, transition to WiltedState
        if (plantAction.CurrentWater < 5f || plantAction.CurrentLove < 5f)
        {
            controller.TransitionToState(new WiltedState());  // Transition to Wilted state
        }
        else
        {
            controller.TransitionToState(new GrowingState());  // Transition to Growing state
        }
    }

    public override void ExitState(StateController controller)
    {
        Debug.Log("Exiting Sprouting State");
    }
}
