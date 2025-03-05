using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


[CreateAssetMenu(menuName = "PluggableSM/Actions/SetText")]
public class SetText : Action
{
    public string text;
    public override void Act(StateController controller)
    {
        MocchiTDController mtdc = (MocchiTDController)controller;
        mtdc.SetText(text);
    }
}