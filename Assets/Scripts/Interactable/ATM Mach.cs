using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATMMach : MonoBehaviour
{
    public float stealDuration;
    private float stealTime = 0;

    public bool IsOpened { get; private set; }
    private bool isStealing = false;

    [SerializeField] private Animator animator;
    private Transform player;
    public GameObject ATMLoading;
    public GameObject itemPrefab; // Item that could drop from ATM
    public Sprite openedSprite; // Changed sprite once opened

    void Start()
    {
        if (ATMLoading != null) animator = ATMLoading.GetComponent<Animator>();

        ATMLoading.SetActive(false);
    }

    void Update()
    {
        if (PauseController.IsGamePaused)
        {
            stealTime = 0;
            if (animator != null && animator.enabled && animator.gameObject.activeInHierarchy)
            {
                animator.Play("ATMLoading", 0, 0f);
            }

            return;
        }

        if (isStealing && !IsOpened)
        {
            if (!ATMLoading.activeSelf) ATMLoading.SetActive(true);
            if (animator != null) animator.Play("ATMLoading");

            stealTime += Time.deltaTime;

            if (stealTime >= stealDuration)
            {
                Debug.Log("ATM stolen");

                if (animator != null) Destroy(animator); animator = null;
                ATMLoading.SetActive(false);

                OpenATM();

                IsOpened = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (IsOpened) return;

        if (other.CompareTag("Player"))
        {
            Debug.Log("ATM stealing");

            player = other.transform;

            isStealing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && isStealing)
        {
            Debug.Log("ATM interuppted");

            if (ATMLoading.activeSelf && animator != null)
            {
                animator.Play("ATMLoading", 0, 0f);
            }

            ATMLoading.SetActive(false);
            isStealing = false;
            stealTime = 0;
        }
    }

    private void OpenATM()
    {
        SetOpened(true);

        if (itemPrefab)
        {
            Instantiate(itemPrefab, transform.position + Vector3.down * 2, Quaternion.identity);
        }
    }

    public void SetOpened(bool opened)
    {
        IsOpened = opened;

        if (opened)
        {
            GetComponent<SpriteRenderer>().sprite = openedSprite;
        }
    }
}
