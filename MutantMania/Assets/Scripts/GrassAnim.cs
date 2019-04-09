using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassAnim : MonoBehaviour {

    private Animator anim;

	void Start ()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetTrigger("wave");
    }
}
