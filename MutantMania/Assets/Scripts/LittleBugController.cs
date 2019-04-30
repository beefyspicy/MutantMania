using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleBugController : MonoBehaviour {

    public float speed;
    //float step;

    public GameObject player;
    public GameObject bloodfx;

    void Update ()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ChaseMonster") || collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Sword"))
        {
            Instantiate(bloodfx, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }
    }

    /*private void OnTriggerStay2D(Collider2D collision)
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
    }*/
}
