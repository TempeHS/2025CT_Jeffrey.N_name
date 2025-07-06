using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{
    public Animator animator;

    [Header("Buttons")]
    public GameObject settings;
    public GameObject play;
    public GameObject howToPlay;
    public GameObject toStartBack;
    public GameObject toStartBack2;
    public GameObject toStartBack3;
    public GameObject toSettingsBack;
    public GameObject toHowToPlayBack;
    public GameObject toControls;
    public GameObject toCredits;

    public void ToPlay()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToPlay");
        EventSystem.current.SetSelectedGameObject(toStartBack);
    }

    public void ToStartBack()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToStartBack");
        EventSystem.current.SetSelectedGameObject(play);
    }

    public void ToSettings()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToSettings");
        EventSystem.current.SetSelectedGameObject(toStartBack2);
    }

    public void ToStartBack2()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToStartBack2");
        EventSystem.current.SetSelectedGameObject(settings);
    }

    public void ToControls()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToControls");
        EventSystem.current.SetSelectedGameObject(toSettingsBack);
    }

    public void ToSettingsBack()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToSettingsBack");
        EventSystem.current.SetSelectedGameObject(toControls);
    }

    public void ToHowToPlay()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToHowToPlay");
        EventSystem.current.SetSelectedGameObject(toStartBack3);
    }

    public void ToStartBack3()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToStartBack3");
        EventSystem.current.SetSelectedGameObject(howToPlay);
    }

    public void ToCredits()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToCredits");
        EventSystem.current.SetSelectedGameObject(toHowToPlayBack);
    }

    public void ToHowToPlayBack()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToHowToPlayBack");
        EventSystem.current.SetSelectedGameObject(toCredits);
    }
}
