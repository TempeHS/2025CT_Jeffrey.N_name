using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMover : MonoBehaviour
{
    [Header("Enemy Brain")]
    public GameObject laserHolder;
    public float detectionRange;
    public LayerMask obstruction;
    public LayerMask playerMask;

    private Transform player;
    private bool isChasing = false;

    [Header("Shoot")]
    public GameObject laserPrefab;
    public float cooldown;

    private float lastShotTime;

    [Header("Movement & Animation")]
    public Transform waypointParent;
    public float moveSpeed;
    public float waitTime;
    public bool loopWaypoints = true;

    private Transform[] waypoints;
    private int currentWaypointIndex;
    private bool isWaiting;
    private Animator animator;

    private float lastInputX;
    private float lastInputY;

    private void Start()
    {
        animator = GetComponent<Animator>();

        player = GameObject.FindGameObjectWithTag("Player").transform;

        waypoints = new Transform[waypointParent.childCount];

        for (int i = 0; i < waypointParent.childCount; i++)
        {
            waypoints[i] = waypointParent.GetChild(i);
        }
    }

    private void Update()
    {
        
        if (PauseController.IsGamePaused || isWaiting)
        {
            animator.SetBool("isWalking", false);
            animator.SetFloat("LastInputX", lastInputX);
            animator.SetFloat("LastInputY", lastInputY);
            return;
        }

        if (IsPlayerInSight())
        {
            animator.SetBool("isWalking", false);
            animator.SetFloat("LastInputX", lastInputX);
            animator.SetFloat("LastInputY", lastInputY);

            Vector2 directionTowardsPlayer = player.position - laserHolder.transform.position;
            laserHolder.transform.up = directionTowardsPlayer;

            isChasing = true;
            Chase();
            Shooting();
            return;
        }

        if (isChasing && !IsPlayerInSight())
        {
            isChasing = false;
        }

        else
        {
            MoveToWaypoint();
        }

    }

    void MoveToWaypoint()
    {
        Transform target = waypoints[currentWaypointIndex];
        Vector2 direction = (target.position - transform.position).normalized;

        if (direction.magnitude > 0f)
        {
            lastInputX = direction.x;
            lastInputY = direction.y;
        }

        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        animator.SetFloat("InputX", direction.x);
        animator.SetFloat("InputY", direction.y);
        animator.SetBool("isWalking", direction.magnitude > 0f);

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            StartCoroutine(WaitAtWayPoint());
        }
    }

    IEnumerator WaitAtWayPoint()
    {
        isWaiting = true;
        animator.SetBool("isWalking", false);

        animator.SetFloat("LastInputX", lastInputX);
        animator.SetFloat("LastInputY", lastInputY);

        yield return new WaitForSeconds(waitTime);

        // If looping is enabled: increment currentWaypointIndex and wrap around if needed
        // If not looping: increment currentWaypointIndex but don't exceed last waypoint

        currentWaypointIndex = loopWaypoints ? (currentWaypointIndex + 1) % waypoints.Length : Mathf.Min(currentWaypointIndex + 1, waypoints.Length - 1);

        isWaiting = false;
    }

    bool IsPlayerInSight()
    {
        var Direction = (player.position - transform.position).normalized;
        var Hit = Physics2D.Raycast(transform.position, Direction, detectionRange, obstruction | playerMask);

        return Hit.collider && Hit.collider.CompareTag("Player");
    }

    void Chase()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);

        /*animator.SetFloat("LastInputX", lastInputX);
        animator.SetFloat("LastInputY", lastInputY);

        lastInputX = direction.x;
        lastInputY = direction.y;*/

        animator.SetFloat("InputX", direction.x);
        animator.SetFloat("InputY", direction.y);
        animator.SetBool("isWalking", true);

        animator.SetFloat("InputX", direction.x);
        animator.SetFloat("InputY", direction.y);
    }

    void Shooting()
    {
        if (Time.time >= lastShotTime + cooldown)
        {
            GameObject laser = Instantiate(laserPrefab, laserHolder.transform.position, laserHolder.transform.rotation);

            Laser laserScript = laser.GetComponent<Laser>();
            if (laserScript != null)
            {
                laserScript.timerController = FindObjectOfType<TimerController>();
            }

            lastShotTime = Time.time;
        }
    }
    void OnDrawGizmos()
    {
        if (player != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, player.position);
        }
    }
}
