using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void AttackLeft(bool Left)
    {
        if (Left)
        {
            Debug.Log("Funciona");
            rend.flipX = true;
            anim.SetBool("hitting", true);
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {

            }
        }
    }

    public void AttackRight(bool Right)
    {
        if (Right)
        {
            Debug.Log("Funciona");
            rend.flipX = false;
            anim.SetBool("hitting", true);
        }

        //if (!Input.GetKey("left") && !Input.GetKey("right"))
        //{
        //    anim.SetBool("hitting", false);
        //}

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
