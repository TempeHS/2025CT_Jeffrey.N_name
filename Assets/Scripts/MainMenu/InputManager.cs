using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Animator animator;

    public void ToPlay()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToPlay");
    }

    public void ToStartBack()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToStartBack");
    }

    public void ToSettings()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToSettings");
    }

    public void ToStartBack2()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToStartBack2");
    }

    public void ToControls()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToControls");
    }

    public void ToSettingsBack()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToSettingsBack");
    }

    public void ToHowToPlay()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("HowToPlay");
    }

    public void ToStartBack3()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToStartBack3");
    }

    public void ToCredits()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToCredits");
    }

    public void ToHowToPlayBack()
    {
        Debug.Log("Play button pressed");
        animator.SetTrigger("ToHowToPlayBack");
    }
}
