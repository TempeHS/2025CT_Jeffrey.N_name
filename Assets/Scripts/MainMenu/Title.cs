using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    [SerializeField] private Animator TitleScreen;
    private Animator PressAnyKey;
    public GameObject title;
    public GameObject pressKey;

    private void Awake()
    {
        PressAnyKey = title.GetComponent<Animator>();
        TitleScreen.enabled = false;
        PressAnyKey.enabled = false;
        pressKey.SetActive(false);
        title.SetActive(false);
    }

    private void Start()
    {
        StartCoroutine(Do());
    }

    private IEnumerator Do()
    {
        yield return new WaitForSeconds(17f);
        TitleScreen.enabled = true;
        title.SetActive(true);
        TitleScreen.SetBool("Switch", true);

        yield return new WaitForSeconds(3.5f);
        PressAnyKey.enabled = true;
        pressKey.SetActive(true);
        TitleScreen.SetBool("Switch", false);
        
    }
}
