using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusicFade : MonoBehaviour {

    public static bool musicFade;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (musicFade)
        {
            anim.SetTrigger("fadeMusic");
        }
    }
}
