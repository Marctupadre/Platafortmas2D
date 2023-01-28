using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoH : MonoBehaviour
{
    public float runSpeed = 2;

    public float jumpSpeed = 3;

    public int velocity = 2;

    Rigidbody2D rb2D;


   
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();



    }

   
    void Update()
    {
        if (Input.GetKey("d") || Input.GetKey("right")) 
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);

        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
        }
        if (Input.GetKey("space") && DetectorGround.isGrounded) 
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);

        }




    }
}
