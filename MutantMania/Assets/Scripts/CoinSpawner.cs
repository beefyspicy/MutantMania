using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    bool canSpawn;

    float coinCount;

    public GameObject enemy;
    public GameObject enemy2;

    public GameObject coin;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
        int r = Random.Range(5, 10);
        int coinNumber = Random.Range(1, 4);


        if (coinCount < coinNumber)
        {
            canSpawn = true;
        }
        else
        {
            canSpawn = false;
        }

		if(!enemy.activeSelf && canSpawn == true)
        {
            coinCount++;
            GameObject coins = Instantiate(coin, enemy.transform.position, enemy.transform.rotation);

            //Rigidbody2D rb = coins.GetComponent<Rigidbody2D>();
            rb = coins.GetComponent<Rigidbody2D>();

            rb.AddForce(transform.right * r);
        }


        /*if (!enemy2.activeSelf && canSpawn == true)
        {
            coinCount++;
            GameObject coins = Instantiate(coin, enemy2.transform.position, enemy2.transform.rotation);

            rb = coins.GetComponent<Rigidbody2D>();

            rb.AddForce(transform.right * r);
        }*/
    }
}