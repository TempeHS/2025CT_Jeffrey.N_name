using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public TextMeshProUGUI countText;

    private int Count = 0;

    void Start()
    {
        Count = 0;
    }

    public void CollectCoin (int value)
    {
        Count += value;
        UpdateCoinCount();
    }

    private void UpdateCoinCount()
    {
        countText.text = "$" + Count.ToString();
    }
}
