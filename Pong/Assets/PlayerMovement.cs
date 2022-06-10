using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float yBound = 2.25f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb.velocity;
        if(Input.GetAxis("Vertical") > 0f)
        {
            vel.y = speed;
        }
        else if(Input.GetAxis("Vertical") < 0f)
        {
            vel.y = -speed;
        }
        else
        {
            vel.y = 0;
        }
        rb.velocity = vel;

        
     
    }
}
