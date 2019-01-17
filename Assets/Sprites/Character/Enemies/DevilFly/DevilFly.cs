using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilFly : MonoBehaviour
{
    bool stop = false;
    bool trigger = false;

    void Update()
    {
        if(stop == false)
        {
            gameObject.GetComponent<Animator>().SetBool("Start", true);
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1f *Time.deltaTime, gameObject.transform.position.y - 0.5f * Time.deltaTime, gameObject.transform.position.z);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            stop = true;
            gameObject.GetComponent<Animator>().SetBool("Attack", true);
        }
        if (collision.transform.tag == "Enemy")
        {

        }
    }
}
