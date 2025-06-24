using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Intro : MonoBehaviour
{
    [SerializeField] private Animator IntroBackground;
    [SerializeField] private Animator Squirrel;
    [SerializeField] private Animator Loading;
    [SerializeField] private Animator ExtraTexts;
    public TMP_Text loadingText;

    private void Awake()
    {
        Squirrel.enabled = false;
        Loading.enabled = false;
        ExtraTexts.enabled = false;
    }

    private void Start()
    {
        StartCoroutine(IntroFade());

    }

    private IEnumerator IntroFade()
    {
        yield return new WaitForSeconds(1.5f);
        Squirrel.enabled = true;

        yield return new WaitForSeconds(0.75f);
        Squirrel.SetBool("SquirrelDance", true);

        yield return new WaitForSeconds(1.25f);
        Loading.enabled = true;

        yield return new WaitForSeconds(1.25f);
        ExtraTexts.enabled = true;
        ExtraTexts.Play("Texts");
        Loading.SetBool("ToLoad", true);

        StartCoroutine(Loads());
        StartCoroutine(Load());

    }

    private IEnumerator Load()
    {
        while (Loading.GetBool("ToLoad"))
        {
            loadingText.text = "Loading";
            yield return new WaitForSecondsRealtime(0.5f);
            loadingText.text = "Loading.";
            yield return new WaitForSecondsRealtime(0.5f);
            loadingText.text = "Loading..";
            yield return new WaitForSecondsRealtime(0.5f);
            loadingText.text = "Loading...";
            yield return new WaitForSecondsRealtime(0.5f);
        }
    }

    private IEnumerator Loads()
    {
        yield return new WaitForSeconds(4.25f);
        Loading.SetBool("ToLoad", false);

        yield return new WaitForSeconds(4f);
        Squirrel.SetBool("SquirrelDance", false);
        IntroBackground.SetBool("FadeOut", true);

        yield return new WaitForSeconds(5f);
        Destroy(IntroBackground);
        Destroy(Squirrel);
        Destroy(Loading);
        Destroy(ExtraTexts);

    }
}
