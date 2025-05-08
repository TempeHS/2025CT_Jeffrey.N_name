using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableGlass : MonoBehaviour
{
    private bool IsOpened;
    public GameObject glassCollision;
    public Sprite openedSprite;

    PlayerMovement playerMovement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsOpened) return;

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with glass");
            PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();

            if (player != null && player.isDashing)
            {
                Debug.Log("Player is dashing, breaking glass");
                SetOpened();
            }
            else
            {
                Debug.Log("Player is not dashing, blocking movement");
                glassCollision.SetActive(true);
            }
        }
    }

    void SetOpened()
    {
        IsOpened = true;

        glassCollision.SetActive(false);

        if (IsOpened)
        {
            GetComponent<SpriteRenderer>().sprite = openedSprite;

            Destroy(glassCollision);
        }
    }

}
