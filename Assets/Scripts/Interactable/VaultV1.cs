using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaultV1 : MonoBehaviour
{
    public float stealDuration;
    private float stealTime = 0;

    public bool IsOpened { get; private set; }
    private bool isStealing = false;

    [SerializeField] private Animator animator;
    private Transform player;
    public GameObject VaultLoading;
    public GameObject itemPrefab; // Item that could drop from ATM
    public Sprite openedSprite; // Changed sprite once opened

    void Start()
    {
        if (VaultLoading != null) animator = VaultLoading.GetComponent<Animator>();

        VaultLoading.SetActive(false);
    }

    void Update()
    {
        if (isStealing && !IsOpened)
        {
            if (!VaultLoading.activeSelf) VaultLoading.SetActive(true);
            if (animator != null) animator.Play("VaultLoading");

            stealTime += Time.deltaTime;

            if (stealTime >= stealDuration)
            {
                Debug.Log("Vault Stolen");

                if (animator != null) Destroy(animator); animator = null;
                VaultLoading.SetActive(false);

                OpenATM();

                IsOpened = true;
            }
        }

        if (PauseController.IsGamePaused)
        {
            stealTime = 0;

            if (VaultLoading.activeSelf && animator != null)
            {
                animator.Play("VaultLoading", 0, 0f);
            }

            return;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (IsOpened) return;

        if (other.CompareTag("Player"))
        {
            Debug.Log("Vault Stealing");

            player = other.transform;

            isStealing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && isStealing)
        {
            Debug.Log("Vault Interuppted");

            if (VaultLoading.activeSelf && animator != null)
            {
                animator.Play("VaultLoading", 0, 0f);
            }

            VaultLoading.SetActive(false);
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
