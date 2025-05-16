using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorTabController : MonoBehaviour
{
    public Image[] MapTabImages;
    public GameObject[] MapPageImages;

    void Start()
    {
        ActivateTab(0);
    }


    public void ActivateTab(int tabno)
    {
        for (int i = 0; i < MapPageImages.Length; i++)
        {
            MapPageImages[i].SetActive(false);
            MapTabImages[i].color = Color.grey;
        }

        MapPageImages[tabno].SetActive(true);
        MapTabImages[tabno].color = Color.white;
    }

}
