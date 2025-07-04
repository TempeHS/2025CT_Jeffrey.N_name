using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnyKey : MonoBehaviour
{
    [SerializeField] private Animator animator;

    

    void Update()
    {

        if (Input.anyKeyDown)
        {
            animator.SetBool("ZoomIn", true);

            StartCoroutine(begin());

        }
    }

    private IEnumerator begin()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
