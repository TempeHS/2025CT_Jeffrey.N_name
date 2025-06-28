using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    [SerializeField] private Animator TitleScreen;
    public GameObject pressKey;

    private void Awake()
    {
        TitleScreen.enabled = false;
        pressKey.SetActive(false);
    }

    private void Start()
    {
        StartCoroutine(Do());
    }

    private IEnumerator Do()
    {
        yield return new WaitForSeconds(15.5f);
        TitleScreen.enabled = true;
        TitleScreen.SetBool("Switch", true);

        yield return new WaitForSeconds(3.5f);
        pressKey.SetActive(true);
        TitleScreen.SetBool("Switch", false);
        
    }
}
