using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/States/DeadState")]
public class DeadState : PlantState
{
    public override void EnterState(StateController controller)
    {
        Debug.Log("The plant has died.");
    }

    public override void UpdateState(StateController controller)
    {
        // No more transitions once dead
    }

    public override void ExitState(StateController controller)
    {
        // Handle cleanup when the plant is removed or reset
    }
}
