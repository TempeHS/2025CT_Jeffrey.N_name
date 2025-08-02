using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin2 : MonoBehaviour
{
    public int value;
    public float stealDuration;
    private float stealTime = 0;

    private bool isStealing = false;
    private bool isMoneyGone = false;

    private Transform player;
    [SerializeField] private Animator animator;
    public GameObject Loading;
    [HideInInspector] public CoinController coinController;

    void Start()
    {
        if (Loading != null) animator = Loading.GetComponent<Animator>();

        Loading.SetActive(false);
    }

    void Update()
    {
        if (isStealing && !isMoneyGone)
        {
            if (!Loading.activeSelf) Loading.SetActive(true);
            if (animator != null) animator.Play("Loading");
            
            stealTime += Time.deltaTime;

            if (stealTime >= stealDuration)
            {
                Debug.Log("Money is stolen");

                if (coinController != null)
                {
                    coinController.CollectCoin(value);
                    Destroy(gameObject); Loading = null;
                }

                isMoneyGone = true;
            }
        }

        if (PauseController.IsGamePaused)
        {
            stealTime = 0;

            if (Loading.activeSelf && animator != null)
            {
                animator.Play("Loading", 0, 0f);
            }

            Debug.Log("Money2.0 Paused");

            return;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {   
        if (isMoneyGone) return;

        if (other.CompareTag("Player"))
        {
            Debug.Log("Stealing started");

            player = other.transform;

            if (coinController == null)
            {
                coinController = FindAnyObjectByType<CoinController>();
            }

            isStealing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {   
        if (other.CompareTag("Player") && isStealing)
        {
            Debug.Log("Stealing interuppted");

            if (Loading.activeSelf && animator != null)
            {
                animator.Play("Loading", 0, 0f);
            }

            Loading.SetActive(false);
            isStealing = false;
            stealTime = 0;
        }
    }
}
