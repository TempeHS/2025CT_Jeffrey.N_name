using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value;

    [HideInInspector] public CoinController coinController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            coinController = FindAnyObjectByType<CoinController>();
            
            if (coinController != null)
            {
                coinController.CollectCoin(value);
                Destroy(gameObject);
            }
        }

    }
}
