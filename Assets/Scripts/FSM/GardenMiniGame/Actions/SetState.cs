using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "PluggableSM/Actions/SetState")]
public class SetState : Action
{
    public State state;
    public override void Act(StateController controller)
    {
        controller.TransitionToState(state);
    }
}