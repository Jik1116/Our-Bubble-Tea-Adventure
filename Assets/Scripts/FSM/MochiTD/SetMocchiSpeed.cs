using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "PluggableSM/Actions/SetMocchiSpeed")]
public class SetMocchiSpeed : Action
{
    public float speed;
    public override void Act(StateController controller)
    {
        MocchiTDController mtdc = (MocchiTDController)controller;
        mtdc.SetSpeed(speed);
    }
}