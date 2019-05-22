using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusicFade : MonoBehaviour {

    public static bool musicFade;

    private Animator anim;

    //AudioSource audioSource;
    //public AudioClip squish;

    void Start()
    {
        anim = GetComponent<Animator>();
        //audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (musicFade)
        {
            anim.SetTrigger("fadeMusic");
            musicFade = false;
        }
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ChaseMonster"))
        {
            audioSource.PlayOneShot(squish, .7f);
        }
    }*/
}
