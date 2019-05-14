using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionAnim : MonoBehaviour {

    public static bool tran;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        if (tran)
        {
            anim.SetTrigger("fadeOut");
        }
    }
}
