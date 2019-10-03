using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speed;
    public float jumpspeed;
    private bool isjumping;
    private Animator animator;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isjumping = true;
        } 

        //else
        //{
        //    animator.SetTrigger("IsJump");
        //}
    }
    private void FixedUpdate()
    {
        Vector3 moveVelocity = Vector3.zero;

        moveVelocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        transform.position += moveVelocity * speed * Time.deltaTime;
        if (rb.velocity.x  != 0 && rb.position.y < -0.4)
        {
            animator.SetTrigger("IsRun");
        }
        else if (rb.position.y < -0.4)
        {
            
            animator.SetTrigger("IsIdle");
        }
        if (isjumping == true)
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0,jumpspeed), ForceMode2D.Impulse);
            animator.SetTrigger("IsJump");
            isjumping = false;
        }
    }
}
