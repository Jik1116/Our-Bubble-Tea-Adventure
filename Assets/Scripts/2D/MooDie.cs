using UnityEngine;

public class MooDie : MonoBehaviour
{
    public void Trigger()
    {
        MooGameUI.instance.CowDown();
        Destroy(gameObject);
    }
}
