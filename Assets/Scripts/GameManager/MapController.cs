using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class MapController : MonoBehaviour
{
    public static MapController Instance { get; set; }

    public RectTransform playerIconTransform;
    public GameObject Map;

    public Color highlightColor = Color.yellow;
    public Color dimmedColor = new Color(1f, 1f, 1f, 0.8f);

    private int currentFloorIndex = 0;

    [SerializeField] private List<GameObject> Floors;
    List<Image> mapImages;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        else
        {
            Instance = this;
        }

        mapImages = Map.GetComponentsInChildren<Image>(true).ToList();

        playerIconTransform.gameObject.SetActive(false);
    }

    public void HighlightArea(string areaName)
    {
        foreach (Image area in mapImages)
        {
            area.color = dimmedColor;
        }

        Image currentArea = mapImages.Find(x => x.name == areaName);

        if (currentArea != null)
        {
            playerIconTransform.gameObject.SetActive(true);

            currentArea.color = highlightColor;
            playerIconTransform.position = currentArea.GetComponent<RectTransform>().position;

            playerIconTransform.SetParent(currentArea.transform.parent, false);
            playerIconTransform.anchoredPosition = currentArea.GetComponent<RectTransform>().anchoredPosition;
        }

        else
        {
            playerIconTransform.gameObject.SetActive(false);

            Debug.LogWarning("This area isn't found -> " + areaName);
        }
    }

    public void SwitchFloor(int floorIndex)
    {
        if (floorIndex < 0 || floorIndex >= Floors.Count) return;

        currentFloorIndex = floorIndex;

        for (int i = 0; i < Floors.Count; i++)
        {
            Floors[i].SetActive(i == floorIndex);
        }

        Debug.Log("Switched to Floor " + floorIndex);
    }
}
