using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f;
    private float resetSpeed = 3f;
    private Rigidbody2D rb;
     public GameObject ball;
    Rigidbody2D ballRB;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        ballRB = ball.GetComponent<Rigidbody2D>();

        if(ballRB.velocity.x > 0)
        {
            if(ballRB.velocity.y > 0)
            {
                if (ballRB.position.y > rb.position.y)
                {
                    MoveUp();
                }
                if (ballRB.position.y < rb.position.y)
                {
                    MoveDown();
                }
            }
            if (ballRB.velocity.y < 0)
            {
                if (ballRB.position.y > rb.position.y)
                {
                    MoveUp();
                }
                if (ballRB.position.y < rb.position.y)
                {
                    MoveDown();
                }
            }
        }
        if(ballRB.velocity.x < 0)
        {
            if(rb.position.y < 0)
            {
                rb.position += Vector2.up * resetSpeed * Time.deltaTime;
            }
            if (rb.position.y > 0)
            {
                rb.position += Vector2.down * resetSpeed * Time.deltaTime;
            }
        }
    }

    void MoveUp()
    {
        rb.MovePosition(rb.position + (Vector2.up * speed * Time.deltaTime));
    }
    void MoveDown()
    {
        rb.MovePosition(rb.position + (Vector2.down * speed * Time.deltaTime));
    }
}
