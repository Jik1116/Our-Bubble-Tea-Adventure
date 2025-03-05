using UnityEngine;

public class PlantStateController : StateController
{
    public enum PlantState
    {
        Seed = 1,
        Adult = 3,
    }

    public PlantState plantState = PlantState.Seed;

    public override void Start()
    {
        base.Start();
    }

    public void Interact()
    {
        this.currentState.DoEventTriggeredActions(this, ActionType.Default);
    }
}
