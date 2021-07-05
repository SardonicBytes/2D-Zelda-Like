using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Character character;
    Rigidbody2D rb;
    Vector2 lastPosition;

    public Vector2 velocity
    {
        get { return rb.velocity; }
    }
    Status status;

    public void Start()
    {
        lastPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetVelocity ( Vector2 direction)
    {
        rb.velocity = direction;
    }

    public void FixedUpdate()
    {
        lastPosition = (Vector2)transform.position;
    }

}
