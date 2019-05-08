using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinPickup : MonoBehaviour {

    public static float coins;
    public static float mana;
    public static float health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            AudioManager.playCoin = true;

            collision.gameObject.SetActive(false);

            //add to player score
            coins += 5;
        }

        if (collision.gameObject.CompareTag("Mana"))
        {
            AudioManager.playMana = true;

            collision.gameObject.SetActive(false);

            //add to player score
            mana += 3;
        }

        /*if (collision.gameObject.CompareTag("HealthBottle"))
        {
            collision.gameObject.SetActive(false);

            //add to player score
            health += 3;
        }*/
    }
}
