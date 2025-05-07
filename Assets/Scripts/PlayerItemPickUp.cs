using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemPickUp : MonoBehaviour
{
    private InventoryController inventoryController;

    void Start()
    {
        inventoryController = FindObjectOfType<InventoryController>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item"))
        {
            Item item = collision.GetComponent<Item>();

            if (item != null)
            {
                bool itemAdded = inventoryController.Additem(collision.gameObject);

                if (itemAdded)
                {
                    Destroy(collision.gameObject);
                }
            }
        }    
    }

}
