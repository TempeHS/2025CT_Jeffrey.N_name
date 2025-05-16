using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public float StartTime;
    private float Timeleft;
    [SerializeField] private float PenaltyTime;

    public GameObject PenaltyText;
    public TMP_Text TimerText;

    public MenuController menuController;

    public Color EndColour = Color.green;

    private void Start()
    {
        Timeleft = StartTime; // Eventually will add a button when the game start
        PenaltyText.SetActive(false); // the timer will happen but for now timer go when game start is fine
    }

    private void Update()
    {
        if (!PauseController.IsGamePaused)
        {
            if (Timeleft > 0)
            {
                FormatToMinSec();

                Timeleft -= Time.deltaTime;

            }
            else
            {
                ChangeTextColour();
                // Change colour text to green
                // Soon if possible, change colour to green if you beat highscore, red if not

            }
        }
    }

    void ChangeTextColour()
    {
        TimerText.color = EndColour;
    }

    void FormatToMinSec()
    {
        int min = Mathf.FloorToInt(Timeleft / 60);
        int sec = Mathf.FloorToInt(Timeleft % 60);
        int mil = Mathf.FloorToInt(Timeleft * 1000) % 1000;
        int milFormatted = mil / 10;

        TimerText.text = string.Format("{0}:{1}:{2:00}", min, sec, milFormatted);

    }

    public float GetTimeLeft()
    {
        return Timeleft;
    }

    public void SetTimeLeft(float newTime)
    {
        Timeleft = newTime;
    }

    public void PenaltyApplied()
    {
        float currentTime = GetTimeLeft();

        currentTime -= PenaltyTime;

        SetTimeLeft(currentTime);

        Debug.Log("Penalty Applied");

        PenaltyText.SetActive(true);
        StartCoroutine(PenaltyTextTime());
    }

    IEnumerator PenaltyTextTime()
    {
        yield return new WaitForSeconds(2f);
        PenaltyText.SetActive(false);
    }

}
