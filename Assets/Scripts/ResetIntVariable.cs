using UnityEngine;

public class ResetIntVariable : MonoBehaviour
{
    public IntVariable intVar;
    public void Trigger()
    {
        intVar.SetValue(0);
    }
}
