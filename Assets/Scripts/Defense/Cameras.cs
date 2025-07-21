using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    [SerializeField] private float Penaltytime;
    [SerializeField] private TimerController timerController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entered trigger");

        if (other.CompareTag("Player"))
        {
            if (timerController != null)
            {
                Debug.Log("Penalty Time");
                timerController.PenaltyApplied(Penaltytime);
            }
        }
    }
}
