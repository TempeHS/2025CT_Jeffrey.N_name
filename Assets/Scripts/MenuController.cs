using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuCanvas;
    public PauseController pauseController;
    public TimerController timerController;


    void Start()
    {
        menuCanvas.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!menuCanvas.activeSelf && PauseController.IsGamePaused)
            {
                return;
            }

            menuCanvas.SetActive(!menuCanvas.activeSelf);
            PauseController.SetPause(menuCanvas.activeSelf);

            timerController.PenaltyApplied();
            
        }
    }

}
