using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Character character;
    Rigidbody2D rb;
    Vector2 lastPosition;
    float accelleration;

    public float groundCheckOffset;
    public float groundCheckRadius;
    public bool IsGrounded;
    public LayerMask groundLayers;

    public virtual bool GroundCheck()
    {
        RaycastHit2D[] checkHits = Physics2D.CircleCastAll(transform.position - new Vector3(0, groundCheckOffset, 0), groundCheckRadius, Vector2.right, groundLayers);
        return (checkHits.Length == 0);
    }

    Vector2 velocity
    {
        get { return (lastPosition - (Vector2)transform.position)/Time.fixedDeltaTime; }
    }
    Status status;

    public void Init(Character newCharacter)
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move ( Vector2 direction)
    {
        rb.velocity = direction;
    }

    public void FixedUpdate()
    {
        lastPosition = (Vector2)transform.position;
        IsGrounded = GroundCheck();
    }

}
