using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private bool triggered = false;
    [SerializeField] private GameObject itemPrefab;
    public void Pickup()
    {
        if (triggered) return;
        InventoryController.instance.AddItem(itemPrefab);
        gameObject.SetActive(false);
        triggered = true;
    }
}
