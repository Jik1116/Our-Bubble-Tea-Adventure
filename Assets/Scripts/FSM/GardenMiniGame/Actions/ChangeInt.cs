using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "PluggableSM/Actions/ChangeInt")]
public class ChangeInt : Action
{
    public IntVariable intVar;
    public int delta;
    public override void Act(StateController controller)
    {
        intVar.SetValue(intVar.Value + delta);
    }
}