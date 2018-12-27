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
    private float move;
    private bool facingRight = true;
    
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	void Update () {
        move = Input.GetAxis("Horizontal");
        anim.SetBool("Ground", isGrounded);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
        {
            Flip();
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
