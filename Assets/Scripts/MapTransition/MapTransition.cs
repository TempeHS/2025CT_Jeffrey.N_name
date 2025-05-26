using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTransition : MonoBehaviour
{
    [SerializeField] PolygonCollider2D mapBoundry;
    [SerializeField] Direction direction;
    [SerializeField] float Additivepos;
    
    PlayerMovement playerMovement;
    CinemachineConfiner confiner;

    enum Direction { Up, Down, Left, Right };

    private void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }


    private void Awake()
    {
        confiner = FindObjectOfType<CinemachineConfiner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerMovement.trailRenderer.time = 0;

            confiner.m_BoundingShape2D = mapBoundry;
            UpdatePlayerPosition(collision.gameObject);

            MapController.Instance?.HighlightArea(mapBoundry.name);
        }
    }

    private void UpdatePlayerPosition(GameObject player)
    {
        Vector3 newPos = player.transform.position;

        switch(direction)
        {
            case Direction.Up:
                newPos.y += Additivepos;
                break;

            case Direction.Down:
                newPos.y -= Additivepos;
                break;

            case Direction.Right:
                newPos.x += Additivepos;
                break;

            case Direction.Left:
                newPos.x -= Additivepos;
                break;
        }

        player.transform.position = newPos;
    }

}
