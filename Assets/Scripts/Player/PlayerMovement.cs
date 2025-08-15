using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movespeed;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 lastMoveInput = Vector2.down;
    private Animator animator;
    public TrailRenderer trailRenderer;

    [Header("Dash Settings")]
    [SerializeField] private Animator animatorDashIcon;
    private float OriginalTrailTime;
    public float dashSpeed;
    public float dashDuration;
    public float dashCooldown;

    [Header("Speed Settings")]
    [SerializeField] private Animator animatorSpeedIcon;
    [SerializeField] private float newSpeed;
    public float speedDuration;
    public float speedCooldown;

    [HideInInspector]  public bool isDashing;
    bool canDash = true;

    void Start()
    {   
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        trailRenderer = GetComponent<TrailRenderer>();

        OriginalTrailTime = trailRenderer.time;

    }

    void Update()
    {
        if (PauseController.IsGamePaused)
        {
            rb.velocity = Vector2.zero;
            animator.SetBool("isWalking", false);
            animatorDashIcon.SetBool("isDashGo", false);

            return;
        }
        
        if (isDashing)
        {
            return;
        }
        
        rb.velocity = moveInput * movespeed;
        animator.SetBool("isWalking", rb.velocity.magnitude > 0);
    }

    public void Move(InputAction.CallbackContext context)
    {


        if (context.canceled)
        {
            animator.SetBool("isWalking", false);
            animator.SetFloat("LastInputX", moveInput.x);
            animator.SetFloat("LastInputY", moveInput.y);
        }

        moveInput = context.ReadValue<Vector2>();

        if (moveInput != Vector2.zero)
        {
            lastMoveInput = moveInput.normalized;
        }

        animator.SetFloat("InputX", moveInput.x);
        animator.SetFloat("InputY", moveInput.y);
    }

    public void Dash(InputAction.CallbackContext context)
    {
        if (context.performed && canDash)
        {
            StartCoroutine(DashCoroutine());
        }
    }

    public void Speed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            StartCoroutine(SpeedCoroutine());
        }
    }

    private IEnumerator DashCoroutine()
    {
        canDash = false;
        isDashing = true;

        trailRenderer.emitting = true;

        animatorDashIcon.SetBool("isDashGo", true);

        Vector2 dashDirection = lastMoveInput;
        rb.velocity = dashDirection * dashSpeed;

        yield return new WaitForSeconds(dashDuration);

        rb.velocity = new Vector2(0f, 0f);

        isDashing = false;
        trailRenderer.emitting = false;

        yield return new WaitForSeconds(dashCooldown);
        canDash = true;

        trailRenderer.time = OriginalTrailTime;

        animatorDashIcon.SetBool("isDashGo", false);
    }

    private IEnumerator SpeedCoroutine()
    {
        animatorSpeedIcon.SetBool("isSpeedGo", true);

        float OriginalSpeed = movespeed;
        movespeed += newSpeed;

        yield return new WaitForSeconds(speedDuration);

        animatorSpeedIcon.SetBool("isSpeedGo", false);

        newSpeed = OriginalSpeed;

        yield return new WaitForSeconds(speedCooldown);

        animatorSpeedIcon.SetTrigger("Switch");

    }
    
}
