using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBarrel : MonoBehaviour
{
    float r;
    float rand;

    public GameObject barrel;
    public GameObject manaBottle;
    public GameObject healthBottle;
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
        rand = Random.Range(0, 4);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sword") && CharacterAnim.attack)
        {
            barrel.SetActive(false);

            p1.SetActive(true);
            p2.SetActive(true);
            p3.SetActive(true);
            p4.SetActive(true);
            p5.SetActive(true);

            //rb.AddForce(transform.forward * r);

            Rigidbody2D rb = p1.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2 = p2.GetComponent<Rigidbody2D>();
            Rigidbody2D rb3 = p3.GetComponent<Rigidbody2D>();
            Rigidbody2D rb4 = p4.GetComponent<Rigidbody2D>();
            Rigidbody2D rb5 = p5.GetComponent<Rigidbody2D>();

            rb.AddForce(transform.up * (r * .6f));
            rb2.AddForce(transform.right * (r * .6f));
            rb3.AddForce(transform.right * (-r * .6f));
            rb4.AddForce(transform.right * (-r * .6f));
            rb5.AddForce(transform.right * (r * .6f));

            if(rand == 0)
            {
                GameObject mana = Instantiate(manaBottle, transform.position, transform.rotation);

                //Rigidbody2D rb = coins.GetComponent<Rigidbody2D>();
                rb = mana.GetComponent<Rigidbody2D>();

                rb.AddForce(transform.up * (r * .6f));
            }
            if (rand == 1)
            {
                GameObject health = Instantiate(healthBottle, transform.position, transform.rotation);

                //Rigidbody2D rb = coins.GetComponent<Rigidbody2D>();
                rb = health.GetComponent<Rigidbody2D>();

                rb.AddForce(transform.up * (r * .6f));
            }

            /*Destroy(p1, 2f);
            Destroy(p2, 2f);
            Destroy(p3, 2f);
            Destroy(p4, 2f);
            Destroy(p5, 2f);*/
        }
        else if (collision.gameObject.CompareTag("ChaseMonster"))
        {
            barrel.SetActive(false);

            p1.SetActive(true);
            p2.SetActive(true);
            p3.SetActive(true);

            //rb.AddForce(transform.forward * r);

            Rigidbody2D rb = p1.GetComponent<Rigidbody2D>();
            Rigidbody2D rb2 = p2.GetComponent<Rigidbody2D>();
            Rigidbody2D rb3 = p3.GetComponent<Rigidbody2D>();

            rb.AddForce(transform.up * (r * .6f));
            rb2.AddForce(transform.right * (r * .6f));
            rb3.AddForce(transform.right * (-r * .6f));
        }
    }
}