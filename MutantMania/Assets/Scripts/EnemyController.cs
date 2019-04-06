using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float enemySpeed;
    public float time;

    private Animator anim;

    private Rigidbody2D rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        rb.velocity = new Vector2(enemySpeed, rb.velocity.y);

        if (EnemyAttack.attack)
        {
            anim.SetTrigger("enemyAttack");
        }
        else
        {
            anim.SetBool("isIdle", true);
        }

        /*if (EnemyAttack.attack)
        {
            if (time <= 0)
            {
                anim.SetTrigger("enemyAttack");
            }
            else
            {
                time -= Time.deltaTime;
            }
        }*/
    }
}
