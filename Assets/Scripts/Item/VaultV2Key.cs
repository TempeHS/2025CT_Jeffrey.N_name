using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultV2Key : Item
{
    public GameObject VaultV2;
    private VaultV2 vaultV2;

    private void Start()
    {
        vaultV2 = GetComponent<VaultV2>();
    }

    public override void UseItem()
    {
        Debug.Log("Using item" + name);

        // QIUOEIOIOIUFFFF
    }
}
