﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakLamp : MonoBehaviour
{
    float r;

    public GameObject lamp;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;

    //private Rigidbody2D rb;

    private void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        r = Random.Range(700, 1000);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            lamp.SetActive(false);

            p1.SetActive(true);
            p2.SetActive(true);
            p3.SetActive(true);

            //rb.AddForce(transform.forward * r);

            Rigidbody2D rb = p1.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2 = p2.GetComponent<Rigidbody2D>();
            Rigidbody2D rb3 = p3.GetComponent<Rigidbody2D>();

            rb.AddForce(transform.up * r);
            rb2.AddForce(transform.right * (r * .6f));
            rb3.AddForce(transform.right * (-r * .6f));

            /*Destroy(p1, 2f);
            Destroy(p2, 2f);
            Destroy(p3, 2f);
            Destroy(p4, 2f);
            Destroy(p5, 2f);*/
        }
    }
}