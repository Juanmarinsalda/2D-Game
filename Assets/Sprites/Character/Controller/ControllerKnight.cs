using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerKnight : MonoBehaviour {
    private Rigidbody2D rb;
    private Animator anim;
    private bool isGrounded = false;
    public Transform groundCheck;
    private float groundRadius = 0.1f;
    public LayerMask queEsGround;
    private bool jumpPresion = false;
    public float jumpFuerza = 700f;
    private float move;
    private bool facingRight = true;
    public float maxSpeed = 10f;
    
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	void Update () {
        move = Input.GetAxis("Horizontal");
        anim.SetFloat("Run", Mathf.Abs(move));
        anim.SetBool("Ground", isGrounded);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
        {
            Flip();
        }
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, queEsGround);
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            isGrounded = false;
            jumpPresion = true;
        }
	 }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);

        if (jumpPresion)
        {
            jumpPresion = false;
            rb.AddForce(new Vector2(0, jumpFuerza));
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
