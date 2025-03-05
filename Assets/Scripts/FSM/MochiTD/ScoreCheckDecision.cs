using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableSM/Decisions/ScoreCheck")]
public class ScoreCheckDecision : Decision
{
    public IntVariable score;
    public int threshold;
    public override bool Decide(StateController controller)
    {
        return score.Value >= threshold;
    }
}