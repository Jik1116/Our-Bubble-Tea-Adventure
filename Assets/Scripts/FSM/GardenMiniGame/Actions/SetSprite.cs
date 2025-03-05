using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "PluggableSM/Actions/SetSprite")]
public class SetSprite : Action
{
    public Sprite sprite;
    public override void Act(StateController controller)
    {
        controller.gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
    }
}