using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    public Image[] TabImages;
    public GameObject[] PageImages;
    [SerializeField] private Animator animatorMapOpen;

    void OnEnable()
    {
        ActivateTab(1);

    }

    public void ActivateTab(int tabno)
    {
        for (int i = 0; i < PageImages.Length; i++)
        {
            PageImages[i].SetActive(false);
            TabImages[i].color = Color.grey;
        }

        PageImages[tabno].SetActive(true);
        TabImages[tabno].color = Color.white;

        if (tabno == 0)
        {
            animatorMapOpen.SetBool("MapTabOpen", true);
        }
        else
        {
            animatorMapOpen.SetBool("MapTabOpen", false);
        }

        
    }

}
