using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class StartAnyKey : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject Intro;
    public InputActionAsset inputActions;

    public GameObject Background;
    public GameObject BulletBoard;
    public GameObject Title;

    private InputAction navigateAction;
    private InputAction submitAction;
    private InputAction cancelAction;
    private InputAction clickAction;

    private void Awake()
    {
        var uiMap = inputActions.FindActionMap("UI");
        uiMap.Disable();
    }

    void Update()
    {

        if (Keyboard.current != null && Keyboard.current.anyKey.wasPressedThisFrame ||Mouse.current.leftButton.wasPressedThisFrame ||
            (Gamepad.current != null && Gamepad.current.wasUpdatedThisFrame && Gamepad.current.buttonSouth.wasPressedThisFrame))
        {
            if (StartMusic.Instance.enabled == true)
            {
                StartMusic.Instance.enabled = false;
                StartMusic.Instance?.stopMusic();
                MusicManager.Instance?.startMusic();
            }

            Destroy(Intro);
            
            animator.SetBool("ZoomIn", true);

            StartCoroutine(Begin());

            var uiMap = inputActions.FindActionMap("UI");
            uiMap.Enable();

        }
    }

    private IEnumerator Begin()
    {
        yield return new WaitForSeconds(2f);
        Destroy(Background);
        Destroy(BulletBoard);
        Destroy(Title);

        animator.enabled = false;
    }

    private void OnEnable()
    {
        var uiMap = inputActions.FindActionMap("UI");

        navigateAction = uiMap.FindAction("Navigate");
        submitAction = uiMap.FindAction("Submit");
        cancelAction = uiMap.FindAction("Cancel");

        navigateAction.performed += OnNavigate;
        submitAction.performed += OnSubmit;
        cancelAction.performed += OnCancel;
    }

    private void OnDisable()
    {
        navigateAction.performed -= OnNavigate;
        submitAction.performed -= OnSubmit;
        cancelAction.performed -= OnCancel;

        inputActions.FindActionMap("UI").Disable();
    }

    private void OnNavigate(InputAction.CallbackContext ctx)
    {
        Vector2 direction = ctx.ReadValue<Vector2>();
        Debug.Log("Navigate: " + direction);
    }

    private void OnSubmit(InputAction.CallbackContext ctx)
    {
        Debug.Log("Submit pressed");
    }

    private void OnCancel(InputAction.CallbackContext ctx)
    {
        Debug.Log("Cancel pressed");
    }
}
