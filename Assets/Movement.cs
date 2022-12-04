using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float movement;
    [SerializeField] int speed = 15;
    [SerializeField] bool isFacingRight=true;
    [SerializeField] Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        if(rb == null) 
        {
            rb = GetComponent<Rigidbody2D>();
        }    

        if(animator == null)
        {
            animator = GetComponent<Animator>();
        }

        animator.SetBool("isRunning", false);
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    void FixedUpdate() 
    {
        rb.velocity = new Vector2(movement * speed, rb.velocity.y);
        //rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        if(movement>0 || movement<0)
        {
            animator.SetBool("isRunning", true);
        }
        else{
            animator.SetBool("isRunning", false);
        }
        if ((movement < 0 && isFacingRight) || (movement > 0 && !isFacingRight)) {
            Flip();
        }
    }

    void Flip()
	{
        isFacingRight = !isFacingRight; 
		transform.Rotate(0f, 180f, 0f);
	}
}
