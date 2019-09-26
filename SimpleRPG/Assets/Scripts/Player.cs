using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float speed;
    public float jumpspeed;
    private bool isjumping;
    private Animator animator;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
            isjumping = true;
        if(rb.velocity == new Vector2(0, 0))
        {
            animator.SetTrigger("isidle");
        }
        else
        {
            animator.SetTrigger("isRun");
        }
    }
    private void FixedUpdate()
    {
        Vector3 moveVelocity = Vector3.zero;

        moveVelocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        transform.position += moveVelocity * speed * Time.deltaTime;

        if(isjumping == true)
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0,jumpspeed), ForceMode2D.Impulse);

            isjumping = false;
        }
    }
}
