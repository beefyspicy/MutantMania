using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseMonsterController : MonoBehaviour {

    public float enemySpeed;
    //public float speed;

    //public GameObject player;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(enemySpeed, rb.velocity.y);

        //float step = speed * Time.deltaTime;
        //transform.position = Vector2.MoveTowards(transform.position, player.transform.position, step);
    }
}
