using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class InventoryController : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject invSlotPrefab;
    public Transform playerTransform;

    public int invSlotCount;
    [HideInInspector] public int selectedIndex = -1;

    public LayerMask collisionLayer;
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
            item.isHeld = true;
            item.UseItem();
        }

        else
        {
            Debug.Log("No Item is in use or in inventory");
            Item previousItem = GetSelectedItem();
            if (previousItem != null)
            {
                previousItem.isHeld = false;
            }
        }
    }

    public void Drop(InputAction.CallbackContext context)
    {
        if (context.performed && selectedIndex >= 0)
        {
            InvSlot invSlot = inventoryPanel.transform.GetChild(selectedIndex).GetComponent<InvSlot>();

            if (invSlot.currentItem != null)
            {
                Item item = invSlot.currentItem.GetComponent<Item>();

                Vector3 dropPosition;
                float dropDistance = 2f;

                if (!Physics2D.Raycast(playerTransform.position, Vector2.down, dropDistance, collisionLayer))
                {
                    dropPosition = playerTransform.position + Vector3.down * dropDistance;
                }
                else
                {
                    dropPosition = playerTransform.position + Vector3.up * dropDistance;
                }

                Instantiate(item.worldItemPrefab, dropPosition, Quaternion.identity);

                DeleteItem();
            }
        }
    }

    public void DeleteItem()
    {
        InvSlot invSlot = inventoryPanel.transform.GetChild(selectedIndex).GetComponent<InvSlot>();

        if (invSlot != null && invSlot.currentItem != null)
        {
            Destroy(invSlot.currentItem);

            invSlot.currentItem = null;
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

    public Item GetSelectedItem()
    {
        if (selectedIndex < 0) return null;

        Transform slotTransform = inventoryPanel.transform.GetChild(selectedIndex);
        InvSlot slot = slotTransform.GetComponent<InvSlot>();

        if (slot == null || slot.currentItem == null) return null;

        return slot.currentItem.GetComponent<Item>();
    }
}
