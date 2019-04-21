using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    public static float score;

    public GameObject bloodfx;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && CharacterAnim.attack == true)
        {
            //Instantiate(bloodfx, collision.transform.position, collision.transform.rotation);
            //HealthController.health -= 1;
            //ScreenShake.shake = true;
            score += 5;
        }

        else if (collision.gameObject.CompareTag("Destructible") && CharacterAnim.attack == true)
        {
            //Instantiate(bloodfx, collision.transform.position, collision.transform.rotation);
            //HealthController.health -= 1;
            ScreenShake.shake = true;
        }
        else
        {
            ScreenShake.shake = false;
        }
    }
}