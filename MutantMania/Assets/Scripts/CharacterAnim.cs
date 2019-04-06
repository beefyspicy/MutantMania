using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour {

    private float time;
    public float startTime;

    static public bool attack;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        time = startTime;
    }

    void Update()
    {
        int r = Random.Range(0, 2);

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(r == 0)
            {
                anim.SetTrigger("jump");
            }
            else if(r == 1)
            {
                anim.SetTrigger("jump2");
            }
        }

        if (time <= 0)
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                attack = true;
                anim.SetTrigger("attack");
                time = startTime;
            }
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
