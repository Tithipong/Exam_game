using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public float walkSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    void Update()
    {

        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        movement = new Vector2(horizontalInput, verticalInput).normalized;

        animator.SetFloat("Horizontal", horizontalInput);
        animator.SetFloat("Vertical", verticalInput);
        animator.SetFloat("Speed", movement.magnitude);


        if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }


        if (verticalInput < 0)
        {

            transform.localScale = new Vector3(transform.localScale.x, 1, 1);
        }
        else if (verticalInput > 0)
        {
            transform.localScale = new Vector3(transform.localScale.x, 1, 1);
        }
    }

    void FixedUpdate()
    {

        rb.MovePosition(rb.position + movement * walkSpeed * Time.fixedDeltaTime);
    }
}
