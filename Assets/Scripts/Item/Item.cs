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


