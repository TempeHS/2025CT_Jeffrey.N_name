using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMapTransition : MonoBehaviour
{
    [SerializeField] private PolygonCollider2D mapBoundry;
    [SerializeField] private Direction direction1;
    [SerializeField] private Direction direction2;
    [SerializeField] private int FloorIndex;
    [SerializeField] private float Additivepos1;
    [SerializeField] private float AdditivePos2;
    private float OriginalTrailTime;


    PlayerMovement playerMovement;
    CinemachineConfiner confiner;

    enum Direction { Up, Down, Left, Right };

    private void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        OriginalTrailTime = playerMovement.trailRenderer.time;
    }


    private void Awake()
    {
        confiner = FindObjectOfType<CinemachineConfiner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ResetTime());

            confiner.m_BoundingShape2D = mapBoundry;
            UpdatePlayerPosition(collision.gameObject);
            UpdatePlayerPosition2(collision.gameObject);

            MapController.Instance?.SwitchFloor(FloorIndex);
            MapController.Instance?.HighlightArea(mapBoundry.name);
        }
    }

    private IEnumerator ResetTime()
    {
        playerMovement.trailRenderer.time = 0;
        yield return new WaitForSeconds(0.05f);
        playerMovement.trailRenderer.time = OriginalTrailTime;
    }

    private void UpdatePlayerPosition(GameObject player)
    {
        Vector3 newPos = player.transform.position;

        switch (direction1)
        {
            case Direction.Up:
                newPos.y += Additivepos1;
                break;

            case Direction.Down:
                newPos.y -= Additivepos1;
                break;

            case Direction.Right:
                newPos.x += Additivepos1;
                break;

            case Direction.Left:
                newPos.x -= Additivepos1;
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
                newPos.y += AdditivePos2;
                break;

            case Direction.Down:
                newPos.y -= AdditivePos2;
                break;

            case Direction.Right:
                newPos.x += AdditivePos2;
                break;

            case Direction.Left:
                newPos.x -= AdditivePos2;
                break;
        }

        player.transform.position = newPos;
    }

}
