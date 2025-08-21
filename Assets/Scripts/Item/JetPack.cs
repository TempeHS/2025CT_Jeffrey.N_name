using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPack : Item
{
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] private float newSpeed;

    private void Update()
    {
        float originalspeed = playerMovement.movespeed;

        if (isHeld)
        {
            playerMovement.movespeed += newSpeed;
        }

        else
        {
            playerMovement.movespeed = originalspeed;
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
