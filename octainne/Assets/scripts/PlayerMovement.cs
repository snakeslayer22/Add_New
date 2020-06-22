using System;
using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    private Rigidbody2D rb;

    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public float speed;
    private Vector2 movement;

    void Start(){
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("SideSpeed", Math.Abs(movement.x));
        animator.SetFloat("UpSpeed", movement.y);
        if (movement.x == -1)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }
}
