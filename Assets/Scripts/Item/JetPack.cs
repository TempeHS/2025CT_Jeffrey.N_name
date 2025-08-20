using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPack : Item
{
    PlayerMovement playerMovement;
    [serializefield] private float newSpeed;
    private float originalspeed;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Start()
    {
        originalspeed = playerMovement.movespeed;
    }

    private void Update()
    {
        if (isHeld)
        {
            playerMovement.movespeed = newSpeed;
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
