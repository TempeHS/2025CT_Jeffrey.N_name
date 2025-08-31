using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPack : Item
{
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] InventoryController inventory;
    [SerializeField] private float newSpeed;
    private float originalspeed;
    private bool changeSpeed = false;

    private void Start()
    {
        originalspeed = playerMovement.movespeed;
    }

    private void Update()
    {
        if (isHeld && !changeSpeed)
        {
            playerMovement.movespeed += newSpeed;
        }

        if (!isHeld && changeSpeed)
        {
            Debug.Log("Speed back to normal");
            playerMovement.movespeed = originalspeed;
            changeSpeed = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Laser") && isHeld)
        {
            Destroy(gameObject);
        }
    }

    
}
