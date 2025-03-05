using UnityEngine;
using TMPro;

public class MocchiTDController : StateController
{
    private TopDownMovement tdMove;
    public TextMeshProUGUI powerText;
    public override void Start()
    {
        tdMove = GetComponent<TopDownMovement>();
        base.Start();
    }
    public void SetSpeed(float speed)
    {
        tdMove.speed = speed;
    }
    public void SetText(string text)
    {
        powerText.text = text;
    }
}
