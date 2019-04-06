using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour {

    public float health;

    private void Update()
    {
        if(health < 1)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sword") && CharacterAnim.attack == true)
        {
            health -= 1;
            CharacterAnim.attack = false;
        }
    }
}
