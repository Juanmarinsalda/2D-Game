using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerKnight : MonoBehaviour
{
	private Rigidbody2D rb;
	private Animator anim;
	private SpriteRenderer rend;
	private float move;
	private bool facingRight = true;
	bool flip = false;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		rend = GetComponent<SpriteRenderer>();
	}
	void Update()
	{
		if (Input.GetKey("right"))
		{
			flip = false;
			rend.flipX = flip;
			anim.SetBool("hitting", true);
		}
		if (Input.GetKey("left"))
		{
			flip = true;
			rend.flipX = flip;
			anim.SetBool("hitting", true);
		}

		if (!Input.GetKey("left") && !Input.GetKey("right"))
		{
			anim.SetBool("hitting", false);
		}

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
