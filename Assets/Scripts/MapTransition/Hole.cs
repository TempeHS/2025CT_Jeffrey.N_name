using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    [Header("Map and Movement")]
    [SerializeField] private PolygonCollider2D mapBoundary;
    [SerializeField] private Direction direction1;
    [SerializeField] private Direction direction2;
    [SerializeField] private float additivePos1;
    [SerializeField] private float additivePos2;

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

            confiner.m_BoundingShape2D = mapBoundary;
            UpdatePlayerPosition(collision.gameObject);
            UpdatePlayerPosition2(collision.gameObject);

            MapController.Instance?.HighlightArea(mapBoundary.name);
        }
    }

    private void UpdatePlayerPosition(GameObject player)
    {
        Vector3 newPos = player.transform.position;

        switch (direction1)
        {
            case Direction.Up:
                newPos.y += additivePos1;

                break;

            case Direction.Down:
                newPos.y -= additivePos1;
                break;

            case Direction.Right:
                newPos.x += additivePos1;
                break;

            case Direction.Left:
                newPos.x -= additivePos1;
                break;
        }

        player.transform.position = newPos;
    }

    private void UpdatePlayerPosition2(GameObject player)
    {
        Vector3 newPos = player.transform.position;

        switch (direction2)
        {
            case Direction.Up:
                newPos.y += additivePos2;
                break;

            case Direction.Down:
                newPos.y -= additivePos2;
                break;

            case Direction.Right:
                newPos.x += additivePos2;
                break;

            case Direction.Left:
                newPos.x -= additivePos2;
                break;
        }

        player.transform.position = newPos;
    }
}
