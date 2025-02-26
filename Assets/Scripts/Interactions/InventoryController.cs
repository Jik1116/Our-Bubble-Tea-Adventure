using UnityEngine;

public class InventoryController : Singleton<InventoryController>
{
    public GameObject slotPrefab;
    public int slotCount;

    void Start()
    {
        for (int i = 0; i < slotCount; i++)
        {
            SlotScript slot = Instantiate(slotPrefab, this.transform).GetComponent<SlotScript>();
        }
    }

    public void AddItem(GameObject item)
    {
        foreach (Transform child in this.transform)
        {
            SlotScript slot = child.GetComponent<SlotScript>();
            if (slot != null && slot.currentItem == null)
            {
                GameObject itemObject = Instantiate(item, this.transform);
                slot.currentItem = itemObject;
                itemObject.transform.SetParent(child);
                itemObject.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
                return;
            }
        }
        Debug.Log("Failed to pick up item, inventory full");
    }
}
