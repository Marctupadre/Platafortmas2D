using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoHorizontal : MonoBehaviour
{
    public float velocidad_grounded = 10;
    public float velocidad_air;
    GroundDetector ground;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        ground = GetComponent<GroundDetector>();

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");


        if (ground.grounded == true)
        {
            horizontal = horizontal * velocidad_grounded;
        }
        else
        {
            animator.SetBool("isWalking", false);
            horizontal = horizontal * velocidad_air;
        }
        if (horizontal > 0)
        {
            animator.SetBool("isWalking", true);
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (horizontal < 0)
        {
            animator.SetBool("isWalking", true);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (horizontal == 0)
            animator.SetBool("isWalking", false);
        transform.position = transform.position + new Vector3(horizontal * Time.deltaTime, 0, 0);
    }
}