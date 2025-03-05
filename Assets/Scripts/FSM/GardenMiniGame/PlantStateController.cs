using UnityEngine;

public class PlantStateController : StateController
{
    public void Interact()
    {
        this.currentState.DoEventTriggeredActions(this, ActionType.Default);
    }
}
