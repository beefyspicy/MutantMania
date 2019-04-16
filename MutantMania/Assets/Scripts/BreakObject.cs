using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakObject : MonoBehaviour {

    float r;

    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;

    //private Rigidbody2D rb;

    private void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        r = Random.Range(300, 700);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            Instantiate(p1, transform.position, transform.rotation);
            Instantiate(p2, transform.position, transform.rotation);
            Instantiate(p3, transform.position, transform.rotation);
            Instantiate(p4, transform.position, transform.rotation);
            Instantiate(p5, transform.position, transform.rotation);

           //rb.AddForce(transform.forward * r);

            Rigidbody2D rb = p1.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2 = p2.GetComponent<Rigidbody2D>();
            Rigidbody2D rb3 = p3.GetComponent<Rigidbody2D>();
            Rigidbody2D rb4 = p4.GetComponent<Rigidbody2D>();
            Rigidbody2D rb5 = p5.GetComponent<Rigidbody2D>();

            rb.AddForce(transform.right * r);
            rb2.AddForce(transform.up * r);
            rb3.AddForce(transform.right * r);
            rb4.AddForce(transform.up * r);
            rb5.AddForce(transform.right * r);

            /*Destroy(p1, 2f);
            Destroy(p2, 2f);
            Destroy(p3, 2f);
            Destroy(p4, 2f);
            Destroy(p5, 2f);*/

            gameObject.SetActive(false);
        }
    }
}
