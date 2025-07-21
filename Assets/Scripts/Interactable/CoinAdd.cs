using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAdd : MonoBehaviour
{
    public float stealDuration;
    private float stealTime = 0;

    public bool IsOpened { get; private set; }
    private bool isStealing = false;

    [SerializeField] private Animator animator;
    private Transform player;
    public CoinController coinController;
    public int coinValue;
    public GameObject ATMLoading;
    public Sprite openedSprite; // Changed sprite once opened

    void Start()
    {
        if (ATMLoading != null) animator = ATMLoading.GetComponent<Animator>();

        ATMLoading.SetActive(false);
    }

    void Update()
    {
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

        if (PauseController.IsGamePaused)
        {
            stealTime = 0;
            if (animator == null) animator.Play("ATMLoading", 0, 0f);

            return;
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
            Debug.Log("Thing Interuppted");

            if (animator != null) animator.Play("ATMLoading", 0, 0f);
            ATMLoading.SetActive(false);

            isStealing = false;
            stealTime = 0;
        }
    }

    private void OpenATM()
    {
        SetOpened(true);

        if (coinController != null)
        {
            coinController.CollectCoin(coinValue);
        }
        else
        {
            Debug.LogWarning("Something is wrong");
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
