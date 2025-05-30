using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject worldItemPrefab;
    public string itemID;

    public virtual void UseItem()
    {
        Debug.Log("Using item" + name);
    }

}

// Create a new script with the following stuff
/*
public class Key : Item
{
    public override void UseItem()
    {
        // Code where the item would be used
    }
}

Then in another script with box collider set on trigger and a child collider gameobject

InventoryController inventoryController

private void Awake()
{
    inventoryController = GetComponent<InventoryController>();
}

private void OnTriggerEnter2D(Collider2D collision)
{
    foreach (Transform child in Parent.transform)
    {
        if (child.name == "Childname")
        {
            GameObject childname;
        }
    }
    if (collision.gameObject.CompareTag("Player"))
}
*/


