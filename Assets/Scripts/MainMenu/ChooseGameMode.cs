using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChooseGameMode : MonoBehaviour
{
    public GameObject backGround;
    
    [Header("Animations")]
    [SerializeField] private Animator GhostAni;
    [SerializeField] private Animator NormalAni;
    [SerializeField] private Animator BlitzAni;

    [Header("Buttons")]
    public Button ghost;
    public Button normal;
    public Button blitz;
    public Button back;

    public void OnGhostClicked()
    {
        backGround.SetActive(true);

        back.interactable = false;
        normal.interactable = false;
        blitz.interactable = false;
        
        GhostAni.SetBool("Choose1", true);
        NormalAni.SetBool("Chose2", true);
        BlitzAni.SetBool("Chose3", true);

        StartCoroutine(End1());
    }

    public void OnNormalClicked()
    {
        backGround.SetActive(true);
        
        back.interactable = false;
        ghost.interactable = false;
        blitz.interactable = false;

        GhostAni.SetBool("Chose1", true);
        NormalAni.SetBool("Choose2", true);
        BlitzAni.SetBool("Chose3", true);

        StartCoroutine(End2());
    }

    public void OnBlitzClicked()
    {
        backGround.SetActive(true);

        back.interactable = false;
        ghost.interactable = false;
        normal.interactable = false;

        GhostAni.SetBool("Chose1", true);
        NormalAni.SetBool("Chose2", true);
        BlitzAni.SetBool("Choose3", true);

        StartCoroutine(End3());
    }

    private IEnumerator End1()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Game2"); // Would be Game1 but not done yet
    }

    private IEnumerator End2()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Game2");
    }

    private IEnumerator End3()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Game2"); // Would be Game3 but not done yet
    }

}
