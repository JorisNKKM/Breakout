using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
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
}