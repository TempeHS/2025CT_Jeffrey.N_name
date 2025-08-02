using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Animator animator;
    public float StartTime;
    private float Timeleft;

    public TMP_Text PenaltyText;
    public TMP_Text TimerText;

    public MenuController menuController;

    public Color EndColour;
    public Color EscapeColour;

    private void Start()
    {
        Timeleft = StartTime; // Eventually will add a button when the game start
        PenaltyText.gameObject.SetActive(false); // the timer will happen but for now timer go when game start is fine
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
                GameMusic.Instance?.stopMusic();
                animator.SetTrigger("Escape");
                SceneManager.LoadScene("Lose");
            }
        }
    }

    void ChangeTextColour()
    {
        TimerText.color = EndColour;
    }

    public void EscapeTextColour()
    {
        TimerText.color = EscapeColour;
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

    public void PenaltyApplied(float penalty)
    {
        float currentTime = Mathf.Max(0f, GetTimeLeft() - penalty);
        SetTimeLeft(currentTime);

        Debug.Log("Penalty Applied");

        PenaltyText.text = $"-{penalty:F2}";
        PenaltyText.gameObject.SetActive(true);

        StartCoroutine(PenaltyTextTime());
    }

    IEnumerator PenaltyTextTime()
    {
        yield return new WaitForSeconds(2f);
        PenaltyText.gameObject.SetActive(false);
    }

}
