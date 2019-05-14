using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionAnimForest : MonoBehaviour {

    public static bool forestTran;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (forestTran)
        {
            anim.SetTrigger("forestFadeOut");
            forestTran = false;
        }
    }
}
