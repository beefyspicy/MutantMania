using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloakHealthController2 : MonoBehaviour {

    public static float health = 3;
    float coinCount;

    bool canSpawn;

    public GameObject coin;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (health < 1)
        {
            //spawn coins
            int r = Random.Range(990, 1000);
            int coinNumber = Random.Range(2, 4);

            coinCount++;
            GameObject coins = Instantiate(coin, transform.position, transform.rotation);
            rb = coins.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * r);

            if (coinCount < coinNumber)
            {
                coinCount++;
                GameObject coins2 = Instantiate(coin, transform.position, transform.rotation);
                rb = coins2.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.right * r);

                if (coinCount < coinNumber)
                {
                    coinCount++;
                    GameObject coins3 = Instantiate(coin, transform.position, transform.rotation);
                    rb = coins3.GetComponent<Rigidbody2D>();
                    rb.AddForce(transform.right * -r);
                }
            }

            AudioManager.playEnemySquish = true;

            gameObject.SetActive(false);
        }
    }
}
