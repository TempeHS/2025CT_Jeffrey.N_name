using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PowerBox : MonoBehaviour
{
    public GameObject[] Laser;
    public Collider2D Collision;
    public float StartTime;
    private float Timeleft;

    public TMP_Text Timer;

    private void Start()
    {
        Collision = GetComponent<Collider2D>();
        Timer.enabled = false;
    }

    private void Update()
    {
        if (PauseController.IsGamePaused)
        {             
            return;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Timeleft = StartTime;

            if (!PauseController.IsGamePaused)
            {
                Timer.enabled = true;

                DisableDefense();
                StartCoroutine(TimerCountdown());
            }
        }
    }

    private IEnumerator TimerCountdown()
    {
        while (Timeleft > 0)
        {
            FormatToMinSec();

            Timeleft -= Time.deltaTime;
            yield return null;
        }

        Timer.enabled = false;
        Timeleft = 0f;
        FormatToMinSec();

        EnableDefense();
    }

    void FormatToMinSec()
    {
        int sec = Mathf.FloorToInt(Timeleft % 60);
        int mil = Mathf.FloorToInt(Timeleft * 1000) % 1000;
        int milFormatted = mil / 10;

        Timer.text = string.Format("{0}:{1:00}", sec, milFormatted);
    }

    void DisableDefense()
    {
        Collision.enabled = false;

        foreach (GameObject laser in Laser)
        {
            laser.SetActive(false);
        }

    }

    void EnableDefense()
    {
        Collision.enabled = true;

        foreach (GameObject laser in Laser)
        {
            laser.SetActive(true);
        }
    }

}
