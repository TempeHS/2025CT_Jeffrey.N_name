using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTransition : MonoBehaviour
{
    [SerializeField] private PolygonCollider2D mapBoundry;
    [SerializeField] private Direction direction;
    [SerializeField] private float Additivepos;
    private float OriginalTrailTime;
    public float vcamSize = 6;
    
    PlayerMovement playerMovement;
    CinemachineConfiner confiner;
    public CinemachineVirtualCamera vcam;

    enum Direction { Up, Down, Left, Right };

    private void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        OriginalTrailTime = playerMovement.trailRenderer.time;
        vcam = FindObjectOfType<CinemachineVirtualCamera>();
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
            vcam.m_Lens.OrthographicSize = vcamSize;

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
