using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float enemySpeed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(enemySpeed, rb.velocity.x);
        //rb.velocity = new Vector2(enemySpeed, rb.velocity.y);
    }
}
