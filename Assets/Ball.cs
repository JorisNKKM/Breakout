using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    public static UnityEvent onBallLose = new();
    Rigidbody2D rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(1, -1);
    }

    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        var brick = other.gameObject.GetComponent<Brick>();

        if (brick != null)
        {
            brick.Break();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        onBallLose.Invoke();
        Destroy(gameObject);
    }
}