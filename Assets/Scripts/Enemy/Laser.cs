using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float penaltyTime;
    public LayerMask collisionLayer;
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
            if (timerController != null)
            {
                timerController.PenaltyApplied(penaltyTime);
            }

            Destroy(gameObject);
        }

        if (collision.CompareTag("Collision"))
        {
            Destroy(gameObject);
        }
    }

    private IEnumerator Explode()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
