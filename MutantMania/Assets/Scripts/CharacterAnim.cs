using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour {

    private float time;
    public float startTime;

    static public bool attack;

    public GameObject swordTrail;
    public GameObject swordTrail2;
    public GameObject swordTrail3;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        time = startTime;
    }

    void Update()
    {
        //attack = false; ///////////

        int r = Random.Range(0, 2);

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || PlayerController.moveHorizontal < 0 || PlayerController.moveHorizontal > 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Joystick1Button1))
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
            if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Joystick1Button0))
            {
                attack = true;
                anim.SetTrigger("attack");
                time = startTime;
                swordTrail.SetActive(true);
                swordTrail2.SetActive(true);
                swordTrail3.SetActive(true);
            }
            else
            {
                swordTrail.SetActive(false);
                swordTrail2.SetActive(false);
                swordTrail3.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.Joystick1Button2))
            {
                attack = true;
                anim.SetTrigger("ninjaThrow");
                time = startTime;
            }
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
