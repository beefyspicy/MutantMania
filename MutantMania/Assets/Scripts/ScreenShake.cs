using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour {

    private Animator anim;

    public static bool shake;

    void Start ()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(shake)
        {
            anim.SetTrigger("shake");
            //anim.SetBool("shake", true);
        }
        else
        {
            anim.SetTrigger("idle");
        }
    }
}
