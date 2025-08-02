using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator animator;
    public BoxCollider2D theCollider;
    public Animator animatorText;
    public TMP_Text itemNeedText;

    [Header("Door Settings")]
    public string requiredItemID;
    public float activationDistance;

    [Header("References")]
    public Transform playerTransform;

    private bool isOpen = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        itemNeedText.enabled = false;
    }

    private void Update()
    {
        if (isOpen || playerTransform == null)
        {
            return;
        }

        float distance = Vector3.Distance(transform.position, playerTransform.position);

        if (distance <= activationDistance)
        {
            InventoryController inventory = FindObjectOfType<InventoryController>();
            Item heldItem = inventory?.GetSelectedItem();

            if (heldItem == null)
            {
                Debug.Log($"Need {requiredItemID} to unlock door");
                itemNeedText.text = $"Need {requiredItemID} to unlock door";

                StartCoroutine(TextFade());

                return;
            }

            if (heldItem.itemID == requiredItemID)
            {
                OpenDoor();
            }
            else
            {
                Debug.Log($"Need {requiredItemID} to unlock door");
                itemNeedText.text = $"Need {requiredItemID} to unlock door";

                StartCoroutine(TextFade());
            }
        }

    }

    void OpenDoor()
    {
        theCollider.enabled = false;
        activationDistance = 0;
        itemNeedText.enabled = false;

        animator.SetBool("OpenDoor", true);
    }

    private IEnumerator TextFade()
    {
        itemNeedText.enabled = true;

        yield return new WaitForSeconds(2f);

        itemNeedText.enabled = false;
    }

}
