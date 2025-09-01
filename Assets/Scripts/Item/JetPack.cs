using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPack : Item
{
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] private float Speedincrease;
    private float originalspeed;
    private bool changeSpeed = false;

    private void Awake()
    {
        originalspeed = playerMovement.movespeed;
    }

    private void Update()
    {
        if (isHeld && !changeSpeed)
        {
            UseItem();
        }

        else if (!isHeld && changeSpeed)
        {
            Debug.Log("Speed back to normal");
            playerMovement.movespeed = originalspeed;
            changeSpeed = false;
        }
    }

    public override void UseItem()
    {
        // Item is now going to be a consumable so if you use the jetpack it permanently increases the speed by a certain amount
        // Because the script is only activated if you hold it (inventory controller problem) so I can't really do
        // Any items except for consumables because the item will still be active if you don't hold it

        playerMovement.movespeed += Speedincrease;
        changeSpeed = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Laser") && isHeld)
        {
            Destroy(gameObject);
        }
    }

    
}
