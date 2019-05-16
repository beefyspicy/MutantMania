using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour {

    public float health;
    float coinCount;

    bool canSpawn;

    public GameObject coin;
    public GameObject bloodfx;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(health < 1)
        {
            //spawn coins
            int r = Random.Range(990, 1000);
            int coinNumber = Random.Range(2, 4);

            coinCount++;
            GameObject coins = Instantiate(coin, transform.position, transform.rotation);
            rb = coins.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * r);

            if(coinCount < coinNumber)
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

            //play sound
            AudioManager.playEnemySquish = true;

            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sword") && CharacterAnim.attack == true)
        {
            PlayerAttack.score += 5;   ///////////////////////////////

            AudioManager.playEnemyHit = true;

            Instantiate(bloodfx, transform.position, transform.rotation);
            ScreenShake.shake = true;
            Debug.Log("shake = true");

            health -= 1;
            CharacterAnim.attack = false;
        }
    }
}
