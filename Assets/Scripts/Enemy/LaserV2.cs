using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserV2 : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float penaltyTime;

    public TimerController timerController;

    void Start()
    {
        StartCoroutine(Explode());
    }

    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            transform.localScale *= 5f;

            if (timerController != null)
            {
                timerController.PenaltyApplied(penaltyTime);
            }

            Destroy(gameObject);
        }
    }

    private IEnumerator Explode()
    {
        yield return new WaitForSeconds(lifeTime);

        transform.localScale *= 5f;

        yield return new WaitForSeconds(0.2f);

        Destroy(gameObject);
    }
}
