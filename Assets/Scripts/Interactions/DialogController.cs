using UnityEngine;

public class DialogController : MonoBehaviour
{
    public int currentScript = 0;
    public DialogScript[] scripts;
    public DialogCanvasController canvasController;

    public void Trigger()
    {
        canvasController.StartDialog(scripts[currentScript]);
    }
}
