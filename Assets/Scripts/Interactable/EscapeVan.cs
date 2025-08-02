using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeVan : MonoBehaviour
{
    public CoinController coinController;
    public TimerController timerController;
    public Animator animator;
    public TMP_Text Begin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(ChooseEnding());
            PauseController.SetPause(true);
            
        }
    }

    private IEnumerator ChooseEnding()
    {
        Begin.enabled = false;

        int Count = coinController.Count;

        timerController.EscapeTextColour();
        animator.SetTrigger("Escape");

        GameStats.TimeLeft = timerController.GetTimeLeft();
        GameStats.Coins = coinController.Count;
        GameMusic.Instance?.stopMusic();

        yield return new WaitForSeconds(2f);

        if (Count == 0)
        {
            SceneManager.LoadScene("Ending1");
        }
        else if (Count > 0 && Count <= 500000)
        {
            SceneManager.LoadScene("Ending2");
        }
        else if (Count > 500000 && Count <= 1000000)
        {
            SceneManager.LoadScene("Ending3");
        }
        else // Count > 1000000
        {
            SceneManager.LoadScene("Ending4");

        }

    }
}
