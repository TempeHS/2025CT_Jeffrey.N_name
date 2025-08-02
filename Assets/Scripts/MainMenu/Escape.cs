using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    public TMP_Text MoneyCount;
    public TMP_Text TimerCount;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("MainMenu");
        }

        TimerCount.text = GameStats.TimeLeft.ToString("F2");
        MoneyCount.text = GameStats.Coins.ToString();
    }
}
