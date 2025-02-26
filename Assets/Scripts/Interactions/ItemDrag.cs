using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Transform originalParent;
    private CanvasGroup cg;

    void Start()
    {
        cg = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;
        transform.SetParent(transform.root);
        cg.blocksRaycasts = false;
        cg.alpha = 0.6f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        cg.blocksRaycasts = true;
        cg.alpha = 1.0f;

        GameObject hoverObj = eventData.pointerEnter;
        SlotScript dropSlot = hoverObj?.GetComponent<SlotScript>();
        if (dropSlot == null)
        {
            dropSlot = hoverObj.GetComponentInParent<SlotScript>();
        }
        SlotScript originalSlot = originalParent.GetComponent<SlotScript>();

        if (dropSlot == null)
        {
            transform.SetParent(originalParent);
            GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
            return;
        }

        if (dropSlot.currentItem != null)
        {
            originalSlot.currentItem = dropSlot.currentItem;
            dropSlot.currentItem.transform.SetParent(originalSlot.transform);
            dropSlot.currentItem.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
        }
        else
        {
            originalSlot.currentItem = null;
        }

        transform.SetParent(dropSlot.transform);
        dropSlot.currentItem = gameObject;
        GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
    }
}