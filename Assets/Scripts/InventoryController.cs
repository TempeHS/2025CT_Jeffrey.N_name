using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static UnityEditor.Progress;

public class InventoryController : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject invSlotPrefab;

    public int invSlotCount;
    private int selectedIndex = -1;

    public Key[] inventorykeys;


    private void Start()
    {
        inventorykeys = new Key[invSlotCount];

        for (int i = 0; i < inventorykeys.Length; i++)
        {
            Instantiate(invSlotPrefab, inventoryPanel.transform);

            inventorykeys[i] = i < invSlotCount ? (Key)((int)Key.Digit1 + i) : Key.Digit0;
        }

        foreach (Transform slotTransform in inventoryPanel.transform)
        {
            Outline outline = slotTransform.GetComponent<Outline>();
            if (outline != null)
            {
                outline.enabled = false;
            }
        }
    }

    void Update()
    {
        for (int i = 0; i < invSlotCount; i++)
        {

            if (Keyboard.current[inventorykeys[i]].wasPressedThisFrame) // Switch between inventory using arrowkeys
            {
                HighLightSlot(i);
                UseItemInSlot(i);
            }
        }
    }

    public bool Additem(GameObject itemPrefab)
    {
        foreach (Transform slotTransform in inventoryPanel.transform)
        {
            InvSlot slot = slotTransform.GetComponent<InvSlot>();

            if (slot != null && slot.currentItem == null)
            {
                GameObject newItem = Instantiate(itemPrefab, slotTransform);
                newItem.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
                slot.currentItem = newItem;
                return true;
            }
        }


        Debug.Log("Inventory full");
        return false;

    }

    void UseItemInSlot(int index)
    {
        InvSlot invSlot = inventoryPanel.transform.GetChild(index).GetComponent<InvSlot>();

        if (invSlot.currentItem != null)
        {
            Item item = invSlot.currentItem.GetComponent<Item>();
            item.UseItem();
        }

        else
        {
            Debug.Log("No Item is in use or in inventory");
        }
    }

    void HighLightSlot(int index)
    {
        if (selectedIndex >= 0)
        {
            Outline previousOutline = inventoryPanel.transform.GetChild(selectedIndex).GetComponent<Outline>();
            if (previousOutline != null) previousOutline.enabled = false;
        }

        selectedIndex = index;
        Outline newOutline = inventoryPanel.transform.GetChild(selectedIndex).GetComponent<Outline>();
        if (newOutline != null)
        {
            newOutline.enabled = true;
        }
            
    }
}
