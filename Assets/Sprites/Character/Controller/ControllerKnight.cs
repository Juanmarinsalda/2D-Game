using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerKnight : MonoBehaviour {
    private Rigidbody2D rb;
    private Animator anim;
    private float move;
    private bool facingRight = true;
    
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	void Update ()
    {

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
