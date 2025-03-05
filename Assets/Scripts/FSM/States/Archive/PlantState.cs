using UnityEngine;

public abstract class PlantState : State
{
    public abstract void EnterState(StateController controller);
    public abstract void UpdateState(StateController controller);
    public abstract void ExitState(StateController controller);
}
